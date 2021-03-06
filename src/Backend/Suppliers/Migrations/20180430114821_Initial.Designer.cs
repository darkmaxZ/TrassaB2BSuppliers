﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Suppliers.Database;
using Suppliers.Database.Models;
using System;

namespace Suppliers.Migrations
{
    [DbContext(typeof(SuppliersContext))]
    [Migration("20180430114821_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Suppliers")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("Suppliers.Database.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryTreeId");

                    b.Property<int>("CounteragentId");

                    b.Property<int>("DistributionDealSide");

                    b.Property<int>("DistributionModelRU");

                    b.Property<int>("ResponsibleEmployeeId");

                    b.Property<int>("SupplyDealSide");

                    b.Property<int>("TargetMarketSegmentRU");

                    b.Property<int>("YearOfDistributionRU");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Suppliers.Database.Models.BrandCompetitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryTreeId");

                    b.Property<int>("CompetitorBrandId");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CompetitorBrandId");

                    b.ToTable("BrandCompetitors");
                });

            modelBuilder.Entity("Suppliers.Database.Models.BrandConsumerProfileRU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<int>("ConsumerProfileId");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("BrandConsumerProfilesRU");
                });

            modelBuilder.Entity("Suppliers.Database.Models.BrandContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<int>("ContactId");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("BrandContacts");
                });

            modelBuilder.Entity("Suppliers.Database.Models.BrandRecognition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<int>("ConsumerProfileId");

                    b.Property<int>("Month");

                    b.Property<int>("NumberOfNegativeResponds");

                    b.Property<int>("NumberOfNeutralResponds");

                    b.Property<int>("NumberOfPositiveResponds");

                    b.Property<string>("QualityQuestion")
                        .IsRequired();

                    b.Property<int>("Respondent");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("BrandRecognitionRecords");
                });

            modelBuilder.Entity("Suppliers.Database.Models.BrandSalesChannel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryTreeId");

                    b.Property<int>("TargetMarketSegment");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("BrandSalesChannels");
                });

            modelBuilder.Entity("Suppliers.Database.Models.ComparisonByChannelRecognition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryTreeId");

                    b.Property<int>("ChannelCoverageIndex");

                    b.Property<string>("ChannelType");

                    b.Property<int>("CompetitorBrandId");

                    b.Property<int>("NumberOfChannels");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CompetitorBrandId");

                    b.ToTable("ComparisonsByChannelRecognition");
                });

            modelBuilder.Entity("Suppliers.Database.Models.ComparisonByPopularity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryTreeId");

                    b.Property<int>("CompetitorBrandId");

                    b.Property<int>("ConsumerProfileId");

                    b.Property<int>("PopularityScore");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CompetitorBrandId");

                    b.ToTable("ComparisonsByPopularity");
                });

            modelBuilder.Entity("Suppliers.Database.Models.ComparisonByPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AveragePrice");

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryTreeId");

                    b.Property<int>("CompetitorBrandId");

                    b.Property<int>("PriceCompetitivenessIndex");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CompetitorBrandId");

                    b.ToTable("ComparisonsByPrice");
                });

            modelBuilder.Entity("Suppliers.Database.Models.ComparisonByRangeSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryTreeId");

                    b.Property<int>("CompetitorBrandId");

                    b.Property<int>("NumberOfSKU");

                    b.Property<int>("RangeSizeIndex");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CompetitorBrandId");

                    b.ToTable("ComparisonsByRangeSize");
                });

            modelBuilder.Entity("Suppliers.Database.Models.NetPromoterScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<int>("ConsumerProfileId");

                    b.Property<int>("Month");

                    b.Property<int>("NumberOfNegativeResponds");

                    b.Property<int>("NumberOfNeutralResponds");

                    b.Property<int>("NumberOfPositiveResponds");

                    b.Property<string>("RecomendationQuestion")
                        .IsRequired();

                    b.Property<int>("Respondent");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("NetPromoterScores");
                });

            modelBuilder.Entity("Suppliers.Database.Models.NewCollectionPresentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfPerformance");

                    b.Property<int>("SeasonId");

                    b.Property<string>("Venue");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.ToTable("NewCollectionPresentations");
                });

            modelBuilder.Entity("Suppliers.Database.Models.PotentialMarketRU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnnualPurchaseFrequency");

                    b.Property<int>("AveragePurchaseSize");

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryTreeId");

                    b.Property<int>("ConsumerProfileId");

                    b.Property<int>("NumberOfPotentialConsumers");

                    b.Property<int>("PotentialAnnualMarketRU");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("PotentialMarketsRU");
                });

            modelBuilder.Entity("Suppliers.Database.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<DateTime>("DateOfB2BCatalogFilesAcquisiton");

                    b.Property<DateTime>("DateOfB2BCollectionAndPricePublishing");

                    b.Property<DateTime>("DateOfB2BPreorderCampaignInvitations");

                    b.Property<DateTime>("DateOfBrandStatisticsAcquisition");

                    b.Property<DateTime>("DateOfCatalogAcquisition");

                    b.Property<DateTime>("DateOfCollectionShootingEnd");

                    b.Property<DateTime>("DateOfMoscowShowroomPrep");

                    b.Property<DateTime>("DateOfPrepForPartnerBuyersTrainingActivities");

                    b.Property<DateTime>("DateOfPresentationPrep");

                    b.Property<DateTime>("DateOfProducerPhotoAcquisiton");

                    b.Property<DateTime>("DateOfProducerSampleDispatch");

                    b.Property<DateTime>("DateOfProducerSampleReceipt");

                    b.Property<DateTime>("DateOfRegionalSampleDispatch");

                    b.Property<DateTime>("DateOfRegionalSampleReceipt");

                    b.Property<DateTime>("DateOfShowroomPhoneInvitations");

                    b.Property<int>("SeasonType");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("Suppliers.Database.Models.SeasonDeadline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfCurrentDeadlineBrandManagerPreorderCheck");

                    b.Property<DateTime>("DateOfCurrentDeadlineDeliveryReadyness");

                    b.Property<DateTime>("DateOfCurrentDeadlineOrderPost");

                    b.Property<DateTime>("DateOfCurrentDeadlineOrderProductCommiteeReconciliation");

                    b.Property<DateTime>("DateOfCurrentDeadlineWarehouseOrderReceipt");

                    b.Property<DateTime>("DateOfCurrentDeadlineWarehouseProgramOrderOffer");

                    b.Property<DateTime>("DateOfPartnerPreorderDeadline");

                    b.Property<int>("DeadlineNumber");

                    b.Property<int>("SeasonId");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.ToTable("SeasonDeadlines");
                });

            modelBuilder.Entity("Suppliers.Database.Models.BrandCompetitor", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("BrandCompetitors")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Suppliers.Database.Models.Brand", "CompetitorBrand")
                        .WithMany("Brands")
                        .HasForeignKey("CompetitorBrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.BrandConsumerProfileRU", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("BrandConsumerProfilesRU")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.BrandContact", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("BrandContacts")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.BrandRecognition", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("BrandRecognitionRecords")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.BrandSalesChannel", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("BrandSalesChannels")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.ComparisonByChannelRecognition", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("ComparisonsByChannelRecognition")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Suppliers.Database.Models.Brand", "CompetitorBrand")
                        .WithMany("BrandsComparedByChannelRecognition")
                        .HasForeignKey("CompetitorBrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.ComparisonByPopularity", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("ComparisonsByPopularity")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Suppliers.Database.Models.Brand", "CompetitorBrand")
                        .WithMany("BrandsComparedByPopularity")
                        .HasForeignKey("CompetitorBrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.ComparisonByPrice", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("ComparisonsByPrice")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Suppliers.Database.Models.Brand", "CompetitorBrand")
                        .WithMany("BrandsComparedByPrice")
                        .HasForeignKey("CompetitorBrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.ComparisonByRangeSize", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("ComparisonsByRange")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Suppliers.Database.Models.Brand", "CompetitorBrand")
                        .WithMany("BrandsComparedByRange")
                        .HasForeignKey("CompetitorBrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.NetPromoterScore", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("NetPromoterScores")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.NewCollectionPresentation", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Season", "Season")
                        .WithMany("NewCollectionPresentations")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.PotentialMarketRU", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("PotentialMarketsRU")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.Season", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Brand", "Brand")
                        .WithMany("Seasons")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Suppliers.Database.Models.SeasonDeadline", b =>
                {
                    b.HasOne("Suppliers.Database.Models.Season", "Season")
                        .WithMany("SeasonDeadlines")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
