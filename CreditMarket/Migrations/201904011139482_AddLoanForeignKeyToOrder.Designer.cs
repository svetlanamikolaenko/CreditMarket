// <auto-generated />
namespace CreditMarket.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class AddLoanForeignKeyToOrder : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddLoanForeignKeyToOrder));
        
        string IMigrationMetadata.Id
        {
            get { return "201904011139482_AddLoanForeignKeyToOrder"; }
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
