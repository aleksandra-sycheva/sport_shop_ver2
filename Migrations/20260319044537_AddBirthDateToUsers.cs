using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace sport_shop_ver2.Migrations
{
    /// <inheritdoc />
    public partial class AddBirthDateToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    category_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("categories_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "delevery_points",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    delivery_adress = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("delevery_points_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "manufacturers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    manufacturer_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("manufacturers_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "measures",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    measure_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("measures_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("roles_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "statuses",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("statuses_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    supplier_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("suppliers_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_role = table.Column<short>(type: "smallint", nullable: false),
                    last_name = table.Column<string>(type: "text", nullable: false),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    middle_name = table.Column<string>(type: "text", nullable: false),
                    login = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("users_pkey", x => x.id);
                    table.ForeignKey(
                        name: "users_id_role_fkey",
                        column: x => x.id_role,
                        principalTable: "roles",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "sporting_products",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    art = table.Column<string>(type: "text", nullable: false),
                    product_name = table.Column<string>(type: "text", nullable: false),
                    id_category = table.Column<int>(type: "integer", nullable: false),
                    id_manufacturer = table.Column<int>(type: "integer", nullable: false),
                    id_supplier = table.Column<int>(type: "integer", nullable: false),
                    price = table.Column<string>(type: "text", nullable: false),
                    id_measure = table.Column<int>(type: "integer", nullable: false),
                    discount = table.Column<int>(type: "integer", nullable: false),
                    coint_in_stok = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("sporting_products_pkey", x => x.id);
                    table.ForeignKey(
                        name: "sporting_products_d_category_fkey",
                        column: x => x.id_category,
                        principalTable: "categories",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "sporting_products_id_manufacturer_fkey",
                        column: x => x.id_manufacturer,
                        principalTable: "manufacturers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "sporting_products_id_measure_fkey",
                        column: x => x.id_measure,
                        principalTable: "measures",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "sporting_products_id_supplier_fkey",
                        column: x => x.id_supplier,
                        principalTable: "suppliers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "history_orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order_date = table.Column<DateOnly>(type: "date", nullable: false),
                    delivery_date = table.Column<DateOnly>(type: "date", nullable: false),
                    id_delivery_point = table.Column<int>(type: "integer", nullable: false),
                    id_user = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<int>(type: "integer", nullable: false),
                    id_statuses = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("history_orders_pkey", x => x.id);
                    table.ForeignKey(
                        name: "history_orders_id_delivery_point_fkey",
                        column: x => x.id_delivery_point,
                        principalTable: "delevery_points",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "history_orders_id_statuses_fkey",
                        column: x => x.id_statuses,
                        principalTable: "statuses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "history_orders_id_user_fkey",
                        column: x => x.id_user,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "sporting_products_history_orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_order = table.Column<int>(type: "integer", nullable: false),
                    id_product = table.Column<int>(type: "integer", nullable: false),
                    count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("sporting_products_history_orders_pkey", x => x.id);
                    table.ForeignKey(
                        name: "sporting_products_history_orders_id_order_fkey",
                        column: x => x.id_order,
                        principalTable: "history_orders",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "sporting_products_history_orders_id_product_fkey",
                        column: x => x.id_product,
                        principalTable: "sporting_products",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_history_orders_id_delivery_point",
                table: "history_orders",
                column: "id_delivery_point");

            migrationBuilder.CreateIndex(
                name: "IX_history_orders_id_statuses",
                table: "history_orders",
                column: "id_statuses");

            migrationBuilder.CreateIndex(
                name: "IX_history_orders_id_user",
                table: "history_orders",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "IX_sporting_products_id_category",
                table: "sporting_products",
                column: "id_category");

            migrationBuilder.CreateIndex(
                name: "IX_sporting_products_id_manufacturer",
                table: "sporting_products",
                column: "id_manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_sporting_products_id_measure",
                table: "sporting_products",
                column: "id_measure");

            migrationBuilder.CreateIndex(
                name: "IX_sporting_products_id_supplier",
                table: "sporting_products",
                column: "id_supplier");

            migrationBuilder.CreateIndex(
                name: "IX_sporting_products_history_orders_id_order",
                table: "sporting_products_history_orders",
                column: "id_order");

            migrationBuilder.CreateIndex(
                name: "IX_sporting_products_history_orders_id_product",
                table: "sporting_products_history_orders",
                column: "id_product");

            migrationBuilder.CreateIndex(
                name: "IX_users_id_role",
                table: "users",
                column: "id_role");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sporting_products_history_orders");

            migrationBuilder.DropTable(
                name: "history_orders");

            migrationBuilder.DropTable(
                name: "sporting_products");

            migrationBuilder.DropTable(
                name: "delevery_points");

            migrationBuilder.DropTable(
                name: "statuses");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "manufacturers");

            migrationBuilder.DropTable(
                name: "measures");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
