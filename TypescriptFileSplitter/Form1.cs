using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using NSwag;
using NJsonSchema.CodeGeneration.TypeScript;
using NJsonSchema.CodeGeneration;

namespace TypescriptFileSplitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(beDest.Text))
            {
                MessageBox.Show("The target directory does not exist.");
                return;
            }

            var schemaSwagger = await SwaggerDocument.FromUrlAsync(meURL.Text);

            TypeScriptGeneratorSettings tsGenSettings = new TypeScriptGeneratorSettings()
            {
                ConvertConstructorInterfaceData = true,
                TypeStyle = TypeScriptTypeStyle.KnockoutClass,
                MarkOptionalProperties = true,
                GenerateDefaultValues = false,            
                PropertyNameGenerator = new myPropertyNameGenerator(),
                TypeNameGenerator = new myTypeNameGenerator(),
                TypeScriptVersion = 2.4m
            };

            var _resolver = new TypeScriptTypeResolver(tsGenSettings);
            _resolver.RegisterSchemaDefinitions(schemaSwagger.Definitions);
            var generatorJ = new TypeScriptGenerator(schemaSwagger, tsGenSettings, _resolver);
            var typeDef = generatorJ.GenerateTypes();
            foreach (CodeArtifact codeArtifact in typeDef.Artifacts)
            {
                File.WriteAllText(Path.Combine(beDest.Text, codeArtifact.TypeName + ".ts"), meFileHeader.Text + "\n\n" + codeArtifact.Code);
            }
        }


        private void beDest_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (FolderBrowserDialog of = new FolderBrowserDialog())
            {
                of.Description = "Save location";
                if (of.ShowDialog() == DialogResult.OK) beDest.EditValue = of.SelectedPath;
            }
        }
    }
}
