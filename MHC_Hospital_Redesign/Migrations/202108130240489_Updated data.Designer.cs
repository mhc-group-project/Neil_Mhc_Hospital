
namespace MHC_Hospital_Redesign.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class Updateddata : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(Updateddata));
        
        string IMigrationMetadata.Id
        {
            get { return "202108130240489_Updated data"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
