﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilkyProject.DataAccessLayer.Migrations
{
    public partial class edit_in_related_table_team_member : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_TeamMemberSocialMedias_TeamMemberSocialMediaId",
                table: "TeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_TeamMembers_TeamMemberSocialMediaId",
                table: "TeamMembers");

            migrationBuilder.AddColumn<int>(
                name: "TeamMemberId",
                table: "TeamMemberSocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TeamMemberSocialMedias_TeamMemberId",
                table: "TeamMemberSocialMedias",
                column: "TeamMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMemberSocialMedias_TeamMembers_TeamMemberId",
                table: "TeamMemberSocialMedias",
                column: "TeamMemberId",
                principalTable: "TeamMembers",
                principalColumn: "TeamMemberId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMemberSocialMedias_TeamMembers_TeamMemberId",
                table: "TeamMemberSocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_TeamMemberSocialMedias_TeamMemberId",
                table: "TeamMemberSocialMedias");

            migrationBuilder.DropColumn(
                name: "TeamMemberId",
                table: "TeamMemberSocialMedias");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_TeamMemberSocialMediaId",
                table: "TeamMembers",
                column: "TeamMemberSocialMediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_TeamMemberSocialMedias_TeamMemberSocialMediaId",
                table: "TeamMembers",
                column: "TeamMemberSocialMediaId",
                principalTable: "TeamMemberSocialMedias",
                principalColumn: "TeamMemberSocialMediaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
