using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace SoBugger.WebApi.Data;

public class CustomMigrationsSqlGenerator(MigrationsSqlGeneratorDependencies dependencies)
    : MigrationsSqlGenerator(dependencies)
{
    protected override void Generate(MigrationOperation operation, IModel? model, MigrationCommandListBuilder builder)
    {
        if (operation is AddForeignKeyOperation)
        {
            return;
        }

        base.Generate(operation, model, builder);
    }
}