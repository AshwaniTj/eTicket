using eTicket.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {

                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Description = "This is Hero"

                        },
                             new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Description = "This is Hero"

                        },
                                  new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Description = "This is Hero"

                        },
                                       new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Description = "This is Hero"

                        },
                                            new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Description = "This is Hero"

                        },


                       } );

                    context.SaveChanges();
                }

                //Actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {

                        new Actor()
                        {
                            FullName = "Actor 1",
                            ProfilePictureURL = "C:\\Users\\HP\\source\\repos\\eTicket\\eTicket\\wwwroot\\Images\\1.png",
                            Bio = "This is Hero"

                        },
                                  new Actor()
                        {
                            FullName = "Actor 2",
                            ProfilePictureURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Bio = "This is Hero"

                        },
                                      new Actor()
                        {
                            FullName = "Actor 3",
                            ProfilePictureURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Bio = "This is Hero"

                        },
                                      new Actor()
                        {
                            FullName = "Actor 4",
                            ProfilePictureURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Bio = "This is Hero"

                        },
                          new Actor()
                        {
                            FullName = "Actor 5",
                            ProfilePictureURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Bio = "This is Hero"

                        },


                       });

                    context.SaveChanges();
                }

                //Producer
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {

                        new Producer()
                        {
                            FullName = "Actor 1",
                            ProfilePictureURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Bio = "This is Hero"

                        },
                         new Producer()
                        {
                            FullName = "Actor 2",
                            ProfilePictureURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Bio = "This is Hero"

                        },
                       new Producer()
                        {
                            FullName = "Actor 3",
                            ProfilePictureURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Bio = "This is Hero"

                        },
                       new Producer()
                        {
                            FullName = "Actor 4",
                            ProfilePictureURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Bio = "This is Hero"

                        },
                      new Producer()
                        {
                            FullName = "Actor 5",
                            ProfilePictureURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                            Bio = "This is Hero"

                        },

                       });

                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {

                        new Movie()
                        {
                            Name = "Actor 1",
                            ImageURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                           Description = "This is Hero",
                           Price = 39.50,
                           StartDate =DateTime.Now.AddDays(-10),
                           EndDate = DateTime.Now.AddDays(-2),
                           CinemaId = 1,
                           ProducerId =3,
                           MovieCategory= MovieCategory.Cartoon

                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            ImageURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                           Description = "This is Ghost",
                           Price = 39.50,
                           StartDate =DateTime.Now,
                           EndDate = DateTime.Now.AddDays(7),
                           CinemaId = 4,
                           ProducerId =4,
                           MovieCategory= MovieCategory.Horror

                        },
                             new Movie()
                        {
                            Name = "Race",
                            ImageURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                           Description = "This is Race",
                           Price = 39.50,
                           StartDate =DateTime.Now.AddDays(-10),
                           EndDate = DateTime.Now.AddDays(-5),
                           CinemaId = 1,
                           ProducerId =2,
                           MovieCategory= MovieCategory.Documentary

                        },
                                   new Movie()
                        {
                            Name = "Life",
                            ImageURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                           Description = "This is Life",
                           Price = 39.50,
                           StartDate =DateTime.Now.AddDays(-10),
                           EndDate = DateTime.Now.AddDays(10),
                           CinemaId = 3,
                           ProducerId =3,
                           MovieCategory= MovieCategory.Documentary

                        },
                                  new Movie()
                        {
                            Name = "Recepotion",
                            ImageURL = "https://www.google.com/search?q=actors+images&sxsrf=APq-WBuX5guwDMAb-G60h_H9n4U--64EHQ:1644722550829&tbm=isch&source=iu&ictx=1&vet=1&fir=SeS8Sb7lWsgQgM%252C1FiOFLvHRM6kRM%252C_%253B5q25BSJHiLD0XM%252Cmxc7DzaUBZySEM%252C_%253BtBhQrHzn7up3uM%252CcL_A-A0DBhi6XM%252C_%253BFqOF8CDyX-ztTM%252C1FiOFLvHRM6kRM%252C_%253BME8iMZPNHZKdIM%252CUlX7e8THMHRcnM%252C_%253Bul-XFp3AM-OCaM%252CzXlQUPuMZFwD-M%252C_%253BlW-ubpXVLOaDMM%252CktqEc3osr5_CGM%252C_%253BIxyk7YOp6_burM%252ChC1AoVIYOTuurM%252C_%253BhxvtiYG0MG3aSM%252Cm6W5hir6bSdk_M%252C_%253BrHvLr0Uba85IAM%252CktqEc3osr5_CGM%252C_%253Bc5X66LuuQT9y7M%252Cwi4nxrLRsp3kpM%252C_%253BNuJWlKVtvDx4JM%252CVXHWvq_ZQS9sOM%252C_%253Bntr2VytskifQxM%252Cmxc7DzaUBZySEM%252C_%253BsfaAbyhmCs0SMM%252C1uY39PBCFSsFeM%252C_%253BlNgnn5Y3TWRpFM%252CNsyxP7pt9Z7JAM%252C_%253B1tL21YYQR7zgqM%252C0VB8slj67uMa-M%252C_&usg=AI4_-kQcwgdMZcyLYL6RdA-1S7N67ybaVA&sa=X&ved=2ahUKEwjbpZX73Pv1AhUh7HMBHRhEC2QQ9QF6BAgDEAE#imgrc=SeS8Sb7lWsgQgM",
                           Description = "This is Recepotion",
                           Price = 39.50,
                           StartDate =DateTime.Now,
                           EndDate = DateTime.Now.AddDays(3),
                           CinemaId = 1,
                           ProducerId =1,
                           MovieCategory= MovieCategory.Action

                        },

                       });

                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                                 new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=1

                        },
                                 new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=1

                        },
                             new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=2

                        },
                             new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=3

                        },
                          new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=3

                        },

                        new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=3

                        },
                     new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=4

                        },
                      new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=5

                        },
             
                  //new Actor_Movie()
                  //      {
                  //          ActorId=5,
                  //          MovieId=5

                  //      },
                  //   new Actor_Movie()
                  //      {
                  //          ActorId=3,
                  //          MovieId=6

                  //      },
                  //      new Actor_Movie()
                  //      {
                  //          ActorId=4,
                  //          MovieId=6

                  //      },
                  //         new Actor_Movie()
                  //      {
                  //          ActorId=6,
                  //          MovieId=5

                  //      },

                       });

                    context.SaveChanges();
                }
            }
        
        }
    }
}
