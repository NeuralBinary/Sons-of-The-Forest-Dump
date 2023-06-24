using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000090 RID: 144
[Token(Token = "0x2000090")]
public interface IPlayerStateBackup : IWorldCharacter, IState, IDisposable
{
	// Token: 0x1700028A RID: 650
	// (get) Token: 0x06000510 RID: 1296
	[Token(Token = "0x1700028A")]
	float _Layer0 { [Token(Token = "0x6000510")] get; }

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x06000511 RID: 1297
	[Token(Token = "0x1700028B")]
	float _Layer1 { [Token(Token = "0x6000511")] get; }

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x06000512 RID: 1298
	[Token(Token = "0x1700028C")]
	float _Layer2 { [Token(Token = "0x6000512")] get; }

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x06000513 RID: 1299
	[Token(Token = "0x1700028D")]
	float _Layer3 { [Token(Token = "0x6000513")] get; }

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x06000514 RID: 1300
	[Token(Token = "0x1700028E")]
	float _Layer4 { [Token(Token = "0x6000514")] get; }

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x06000515 RID: 1301
	// (set) Token: 0x06000516 RID: 1302
	[Token(Token = "0x1700028F")]
	int itemInLeftHand { [Token(Token = "0x6000515")] get; [Token(Token = "0x6000516")] set; }

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x06000517 RID: 1303
	// (set) Token: 0x06000518 RID: 1304
	[Token(Token = "0x17000290")]
	int itemInRightHand { [Token(Token = "0x6000517")] get; [Token(Token = "0x6000518")] set; }

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x06000519 RID: 1305
	[Token(Token = "0x17000291")]
	bool stickHeld { [Token(Token = "0x6000519")] get; }

	// Token: 0x17000292 RID: 658
	// (get) Token: 0x0600051A RID: 1306
	[Token(Token = "0x17000292")]
	bool attack { [Token(Token = "0x600051A")] get; }

	// Token: 0x17000293 RID: 659
	// (get) Token: 0x0600051B RID: 1307
	[Token(Token = "0x17000293")]
	int randInt1 { [Token(Token = "0x600051B")] get; }

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x0600051C RID: 1308
	[Token(Token = "0x17000294")]
	float hSpeed { [Token(Token = "0x600051C")] get; }

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x0600051D RID: 1309
	[Token(Token = "0x17000295")]
	float vSpeed { [Token(Token = "0x600051D")] get; }

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x0600051E RID: 1310
	[Token(Token = "0x17000296")]
	float overallSpeed { [Token(Token = "0x600051E")] get; }

	// Token: 0x17000297 RID: 663
	// (get) Token: 0x0600051F RID: 1311
	[Token(Token = "0x17000297")]
	bool AxeAttack { [Token(Token = "0x600051F")] get; }

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x06000520 RID: 1312
	[Token(Token = "0x17000298")]
	float weaponHit { [Token(Token = "0x6000520")] get; }

	// Token: 0x17000299 RID: 665
	// (get) Token: 0x06000521 RID: 1313
	[Token(Token = "0x17000299")]
	bool gunAttack { [Token(Token = "0x6000521")] get; }

	// Token: 0x1700029A RID: 666
	// (get) Token: 0x06000522 RID: 1314
	[Token(Token = "0x1700029A")]
	bool itemHeld { [Token(Token = "0x6000522")] get; }

	// Token: 0x1700029B RID: 667
	// (get) Token: 0x06000523 RID: 1315
	[Token(Token = "0x1700029B")]
	bool axeHeld { [Token(Token = "0x6000523")] get; }

	// Token: 0x1700029C RID: 668
	// (get) Token: 0x06000524 RID: 1316
	[Token(Token = "0x1700029C")]
	bool stickAttack { [Token(Token = "0x6000524")] get; }

	// Token: 0x1700029D RID: 669
	// (get) Token: 0x06000525 RID: 1317
	[Token(Token = "0x1700029D")]
	int hitDirection { [Token(Token = "0x6000525")] get; }

	// Token: 0x1700029E RID: 670
	// (get) Token: 0x06000526 RID: 1318
	[Token(Token = "0x1700029E")]
	bool stickShove { [Token(Token = "0x6000526")] get; }

	// Token: 0x1700029F RID: 671
	// (get) Token: 0x06000527 RID: 1319
	[Token(Token = "0x1700029F")]
	bool smallTree { [Token(Token = "0x6000527")] get; }

	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x06000528 RID: 1320
	[Token(Token = "0x170002A0")]
	bool stickBlock { [Token(Token = "0x6000528")] get; }

	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x06000529 RID: 1321
	[Token(Token = "0x170002A1")]
	bool nextHit { [Token(Token = "0x6000529")] get; }

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x0600052A RID: 1322
	[Token(Token = "0x170002A2")]
	bool flaregunHeld { [Token(Token = "0x600052A")] get; }

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x0600052B RID: 1323
	[Token(Token = "0x170002A3")]
	bool lighterHeld { [Token(Token = "0x600052B")] get; }

	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x0600052C RID: 1324
	[Token(Token = "0x170002A4")]
	bool checkArms { [Token(Token = "0x600052C")] get; }

	// Token: 0x170002A5 RID: 677
	// (get) Token: 0x0600052D RID: 1325
	[Token(Token = "0x170002A5")]
	bool pedHeld { [Token(Token = "0x600052D")] get; }

	// Token: 0x170002A6 RID: 678
	// (get) Token: 0x0600052E RID: 1326
	[Token(Token = "0x170002A6")]
	bool lighterIgnite { [Token(Token = "0x600052E")] get; }

	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x0600052F RID: 1327
	[Token(Token = "0x170002A7")]
	bool flashLightHeld { [Token(Token = "0x600052F")] get; }

	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x06000530 RID: 1328
	[Token(Token = "0x170002A8")]
	bool batteryDead { [Token(Token = "0x6000530")] get; }

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x06000531 RID: 1329
	[Token(Token = "0x170002A9")]
	float normCamX { [Token(Token = "0x6000531")] get; }

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x06000532 RID: 1330
	[Token(Token = "0x170002AA")]
	bool crouchIdle { [Token(Token = "0x6000532")] get; }

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x06000533 RID: 1331
	[Token(Token = "0x170002AB")]
	float normCamY { [Token(Token = "0x6000533")] get; }

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x06000534 RID: 1332
	[Token(Token = "0x170002AC")]
	float pedIdleBlend { [Token(Token = "0x6000534")] get; }

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x06000535 RID: 1333
	[Token(Token = "0x170002AD")]
	float breatheFloat { [Token(Token = "0x6000535")] get; }

	// Token: 0x170002AE RID: 686
	// (get) Token: 0x06000536 RID: 1334
	[Token(Token = "0x170002AE")]
	float tiredFloat { [Token(Token = "0x6000536")] get; }

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x06000537 RID: 1335
	[Token(Token = "0x170002AF")]
	bool rockHeld { [Token(Token = "0x6000537")] get; }

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x06000538 RID: 1336
	[Token(Token = "0x170002B0")]
	bool smashBool { [Token(Token = "0x6000538")] get; }

	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x06000539 RID: 1337
	[Token(Token = "0x170002B1")]
	float aimAtTarget { [Token(Token = "0x6000539")] get; }

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x0600053A RID: 1338
	// (set) Token: 0x0600053B RID: 1339
	[Token(Token = "0x170002B2")]
	float Gravity { [Token(Token = "0x600053A")] get; [Token(Token = "0x600053B")] set; }

	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x0600053C RID: 1340
	[Token(Token = "0x170002B3")]
	bool onHand { [Token(Token = "0x600053C")] get; }

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x0600053D RID: 1341
	[Token(Token = "0x170002B4")]
	bool leanForward { [Token(Token = "0x600053D")] get; }

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x0600053E RID: 1342
	[Token(Token = "0x170002B5")]
	float crouch { [Token(Token = "0x600053E")] get; }

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x0600053F RID: 1343
	[Token(Token = "0x170002B6")]
	bool comboBool { [Token(Token = "0x600053F")] get; }

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x06000540 RID: 1344
	[Token(Token = "0x170002B7")]
	bool bigTree { [Token(Token = "0x6000540")] get; }

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x06000541 RID: 1345
	[Token(Token = "0x170002B8")]
	bool attackHighBool { [Token(Token = "0x6000541")] get; }

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x06000542 RID: 1346
	[Token(Token = "0x170002B9")]
	bool spearHeld { [Token(Token = "0x6000542")] get; }

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x06000543 RID: 1347
	[Token(Token = "0x170002BA")]
	bool ballHeld { [Token(Token = "0x6000543")] get; }

	// Token: 0x170002BB RID: 699
	// (get) Token: 0x06000544 RID: 1348
	[Token(Token = "0x170002BB")]
	bool molotovHeld { [Token(Token = "0x6000544")] get; }

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x06000545 RID: 1349
	[Token(Token = "0x170002BC")]
	bool parryBool { [Token(Token = "0x6000545")] get; }

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x06000546 RID: 1350
	// (set) Token: 0x06000547 RID: 1351
	[Token(Token = "0x170002BD")]
	Action OnknockBackTrigger { [Token(Token = "0x6000546")] get; [Token(Token = "0x6000547")] set; }

	// Token: 0x170002BE RID: 702
	// (get) Token: 0x06000548 RID: 1352
	[Token(Token = "0x170002BE")]
	bool spearRaiseBool { [Token(Token = "0x6000548")] get; }

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x06000549 RID: 1353
	[Token(Token = "0x170002BF")]
	bool walkmanHeld { [Token(Token = "0x6000549")] get; }

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x0600054A RID: 1354
	[Token(Token = "0x170002C0")]
	bool walkmanPlayBool { [Token(Token = "0x600054A")] get; }

	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x0600054B RID: 1355
	[Token(Token = "0x170002C1")]
	float connectFloat { [Token(Token = "0x600054B")] get; }

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x0600054C RID: 1356
	[Token(Token = "0x170002C2")]
	bool movingBool { [Token(Token = "0x600054C")] get; }

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x0600054D RID: 1357
	[Token(Token = "0x170002C3")]
	bool deathBool { [Token(Token = "0x600054D")] get; }

	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x0600054E RID: 1358
	// (set) Token: 0x0600054F RID: 1359
	[Token(Token = "0x170002C4")]
	Action OndeathTrigger { [Token(Token = "0x600054E")] get; [Token(Token = "0x600054F")] set; }

	// Token: 0x170002C5 RID: 709
	// (get) Token: 0x06000550 RID: 1360
	// (set) Token: 0x06000551 RID: 1361
	[Token(Token = "0x170002C5")]
	Action OnresetTrigger { [Token(Token = "0x6000550")] get; [Token(Token = "0x6000551")] set; }

	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x06000552 RID: 1362
	[Token(Token = "0x170002C6")]
	float groundHeight { [Token(Token = "0x6000552")] get; }

	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x06000553 RID: 1363
	[Token(Token = "0x170002C7")]
	bool flareHeld { [Token(Token = "0x6000553")] get; }

	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x06000554 RID: 1364
	[Token(Token = "0x170002C8")]
	bool oculusDemoBool { [Token(Token = "0x6000554")] get; }

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x06000555 RID: 1365
	[Token(Token = "0x170002C9")]
	bool swimmingBool { [Token(Token = "0x6000555")] get; }

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x06000556 RID: 1366
	[Token(Token = "0x170002CA")]
	bool genericHeld { [Token(Token = "0x6000556")] get; }

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x06000557 RID: 1367
	[Token(Token = "0x170002CB")]
	bool genericWideHeld { [Token(Token = "0x6000557")] get; }

	// Token: 0x170002CC RID: 716
	// (get) Token: 0x06000558 RID: 1368
	[Token(Token = "0x170002CC")]
	bool sittingBool { [Token(Token = "0x6000558")] get; }

	// Token: 0x170002CD RID: 717
	// (get) Token: 0x06000559 RID: 1369
	[Token(Token = "0x170002CD")]
	bool birdResetBool { [Token(Token = "0x6000559")] get; }

	// Token: 0x170002CE RID: 718
	// (get) Token: 0x0600055A RID: 1370
	[Token(Token = "0x170002CE")]
	bool logHeld { [Token(Token = "0x600055A")] get; }

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x0600055B RID: 1371
	[Token(Token = "0x170002CF")]
	bool bowHeld { [Token(Token = "0x600055B")] get; }

	// Token: 0x170002D0 RID: 720
	// (get) Token: 0x0600055C RID: 1372
	[Token(Token = "0x170002D0")]
	bool drawBowBool { [Token(Token = "0x600055C")] get; }

	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x0600055D RID: 1373
	// (set) Token: 0x0600055E RID: 1374
	[Token(Token = "0x170002D1")]
	Action OncancelBowTrigger { [Token(Token = "0x600055D")] get; [Token(Token = "0x600055E")] set; }

	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x0600055F RID: 1375
	[Token(Token = "0x170002D2")]
	bool bowFireBool { [Token(Token = "0x600055F")] get; }

	// Token: 0x170002D3 RID: 723
	// (get) Token: 0x06000560 RID: 1376
	[Token(Token = "0x170002D3")]
	bool smallAxe { [Token(Token = "0x6000560")] get; }

	// Token: 0x170002D4 RID: 724
	// (get) Token: 0x06000561 RID: 1377
	[Token(Token = "0x170002D4")]
	bool paddleIdleBool { [Token(Token = "0x6000561")] get; }

	// Token: 0x170002D5 RID: 725
	// (get) Token: 0x06000562 RID: 1378
	[Token(Token = "0x170002D5")]
	bool paddleBool { [Token(Token = "0x6000562")] get; }

	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x06000563 RID: 1379
	[Token(Token = "0x170002D6")]
	bool groundAxeChopBool { [Token(Token = "0x6000563")] get; }

	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x06000564 RID: 1380
	[Token(Token = "0x170002D7")]
	NetworkTransform Transform { [Token(Token = "0x6000564")] get; }

	// Token: 0x170002D8 RID: 728
	// (get) Token: 0x06000565 RID: 1381
	// (set) Token: 0x06000566 RID: 1382
	[Token(Token = "0x170002D8")]
	string name { [Token(Token = "0x6000565")] get; [Token(Token = "0x6000566")] set; }

	// Token: 0x170002D9 RID: 729
	// (get) Token: 0x06000567 RID: 1383
	// (set) Token: 0x06000568 RID: 1384
	[Token(Token = "0x170002D9")]
	int logsHeld { [Token(Token = "0x6000567")] get; [Token(Token = "0x6000568")] set; }

	// Token: 0x170002DA RID: 730
	// (get) Token: 0x06000569 RID: 1385
	// (set) Token: 0x0600056A RID: 1386
	[Token(Token = "0x170002DA")]
	int CurrentView { [Token(Token = "0x6000569")] get; [Token(Token = "0x600056A")] set; }

	// Token: 0x170002DB RID: 731
	// (get) Token: 0x0600056B RID: 1387
	// (set) Token: 0x0600056C RID: 1388
	[Token(Token = "0x170002DB")]
	bool BatteryTorchEnabled { [Token(Token = "0x600056B")] get; [Token(Token = "0x600056C")] set; }

	// Token: 0x170002DC RID: 732
	// (get) Token: 0x0600056D RID: 1389
	// (set) Token: 0x0600056E RID: 1390
	[Token(Token = "0x170002DC")]
	Color BatteryTorchColor { [Token(Token = "0x600056D")] get; [Token(Token = "0x600056E")] set; }

	// Token: 0x170002DD RID: 733
	// (get) Token: 0x0600056F RID: 1391
	// (set) Token: 0x06000570 RID: 1392
	[Token(Token = "0x170002DD")]
	float BatteryTorchIntensity { [Token(Token = "0x600056F")] get; [Token(Token = "0x6000570")] set; }

	// Token: 0x170002DE RID: 734
	// (get) Token: 0x06000571 RID: 1393
	// (set) Token: 0x06000572 RID: 1394
	[Token(Token = "0x170002DE")]
	int PlayerVariation { [Token(Token = "0x6000571")] get; [Token(Token = "0x6000572")] set; }

	// Token: 0x170002DF RID: 735
	// (get) Token: 0x06000573 RID: 1395
	// (set) Token: 0x06000574 RID: 1396
	[Token(Token = "0x170002DF")]
	Action OninjuredTrigger { [Token(Token = "0x6000573")] get; [Token(Token = "0x6000574")] set; }

	// Token: 0x170002E0 RID: 736
	// (get) Token: 0x06000575 RID: 1397
	[Token(Token = "0x170002E0")]
	bool injuredBool { [Token(Token = "0x6000575")] get; }

	// Token: 0x170002E1 RID: 737
	// (get) Token: 0x06000576 RID: 1398
	[Token(Token = "0x170002E1")]
	bool genericHoldPouch { [Token(Token = "0x6000576")] get; }

	// Token: 0x170002E2 RID: 738
	// (get) Token: 0x06000577 RID: 1399
	[Token(Token = "0x170002E2")]
	bool setClimbBool { [Token(Token = "0x6000577")] get; }

	// Token: 0x170002E3 RID: 739
	// (get) Token: 0x06000578 RID: 1400
	// (set) Token: 0x06000579 RID: 1401
	[Token(Token = "0x170002E3")]
	Action OnsetClimbTrigger { [Token(Token = "0x6000578")] get; [Token(Token = "0x6000579")] set; }

	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x0600057A RID: 1402
	// (set) Token: 0x0600057B RID: 1403
	[Token(Token = "0x170002E4")]
	Action OnsetClimbTopTrigger { [Token(Token = "0x600057A")] get; [Token(Token = "0x600057B")] set; }

	// Token: 0x170002E5 RID: 741
	// (get) Token: 0x0600057C RID: 1404
	[Token(Token = "0x170002E5")]
	int climbDirInt { [Token(Token = "0x600057C")] get; }

	// Token: 0x170002E6 RID: 742
	// (get) Token: 0x0600057D RID: 1405
	[Token(Token = "0x170002E6")]
	bool pushSledBool { [Token(Token = "0x600057D")] get; }

	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x0600057E RID: 1406
	// (set) Token: 0x0600057F RID: 1407
	[Token(Token = "0x170002E7")]
	Action OnresetClimbTrigger { [Token(Token = "0x600057E")] get; [Token(Token = "0x600057F")] set; }

	// Token: 0x170002E8 RID: 744
	// (get) Token: 0x06000580 RID: 1408
	[Token(Token = "0x170002E8")]
	bool exitClimbTopBool { [Token(Token = "0x6000580")] get; }

	// Token: 0x170002E9 RID: 745
	// (get) Token: 0x06000581 RID: 1409
	[Token(Token = "0x170002E9")]
	bool lookAtItem { [Token(Token = "0x6000581")] get; }

	// Token: 0x170002EA RID: 746
	// (get) Token: 0x06000582 RID: 1410
	[Token(Token = "0x170002EA")]
	bool lookAtItemRight { [Token(Token = "0x6000582")] get; }

	// Token: 0x170002EB RID: 747
	// (get) Token: 0x06000583 RID: 1411
	[Token(Token = "0x170002EB")]
	bool bodyHeld { [Token(Token = "0x6000583")] get; }

	// Token: 0x170002EC RID: 748
	// (get) Token: 0x06000584 RID: 1412
	[Token(Token = "0x170002EC")]
	int climbTypeInt { [Token(Token = "0x6000584")] get; }

	// Token: 0x170002ED RID: 749
	// (get) Token: 0x06000585 RID: 1413
	[Token(Token = "0x170002ED")]
	bool swimDiveBool { [Token(Token = "0x6000585")] get; }

	// Token: 0x170002EE RID: 750
	// (get) Token: 0x06000586 RID: 1414
	[Token(Token = "0x170002EE")]
	bool shellHeld { [Token(Token = "0x6000586")] get; }

	// Token: 0x170002EF RID: 751
	// (get) Token: 0x06000587 RID: 1415
	[Token(Token = "0x170002EF")]
	bool pointAtMap { [Token(Token = "0x6000587")] get; }

	// Token: 0x170002F0 RID: 752
	// (get) Token: 0x06000588 RID: 1416
	[Token(Token = "0x170002F0")]
	bool mapHeld { [Token(Token = "0x6000588")] get; }

	// Token: 0x170002F1 RID: 753
	// (get) Token: 0x06000589 RID: 1417
	[Token(Token = "0x170002F1")]
	int knockBackInt { [Token(Token = "0x6000589")] get; }

	// Token: 0x170002F2 RID: 754
	// (get) Token: 0x0600058A RID: 1418
	[Token(Token = "0x170002F2")]
	float coldFloat { [Token(Token = "0x600058A")] get; }

	// Token: 0x170002F3 RID: 755
	// (get) Token: 0x0600058B RID: 1419
	[Token(Token = "0x170002F3")]
	bool jumpBool { [Token(Token = "0x600058B")] get; }

	// Token: 0x170002F4 RID: 756
	// (get) Token: 0x0600058C RID: 1420
	[Token(Token = "0x170002F4")]
	int jumpType { [Token(Token = "0x600058C")] get; }

	// Token: 0x170002F5 RID: 757
	// (get) Token: 0x0600058D RID: 1421
	// (set) Token: 0x0600058E RID: 1422
	[Token(Token = "0x170002F5")]
	float sledRotation { [Token(Token = "0x600058D")] get; [Token(Token = "0x600058E")] set; }

	// Token: 0x170002F6 RID: 758
	// (get) Token: 0x0600058F RID: 1423
	// (set) Token: 0x06000590 RID: 1424
	[Token(Token = "0x170002F6")]
	bool FX_Fire { [Token(Token = "0x600058F")] get; [Token(Token = "0x6000590")] set; }

	// Token: 0x170002F7 RID: 759
	// (get) Token: 0x06000591 RID: 1425
	[Token(Token = "0x170002F7")]
	NetworkArray_Integer Leaves { [Token(Token = "0x6000591")] get; }

	// Token: 0x170002F8 RID: 760
	// (get) Token: 0x06000592 RID: 1426
	[Token(Token = "0x170002F8")]
	NetworkArray_Integer Armors { [Token(Token = "0x6000592")] get; }

	// Token: 0x170002F9 RID: 761
	// (get) Token: 0x06000593 RID: 1427
	[Token(Token = "0x170002F9")]
	NetworkArray_Integer MapPieces { [Token(Token = "0x6000593")] get; }

	// Token: 0x170002FA RID: 762
	// (get) Token: 0x06000594 RID: 1428
	[Token(Token = "0x170002FA")]
	bool attackHeavyBool { [Token(Token = "0x6000594")] get; }

	// Token: 0x170002FB RID: 763
	// (get) Token: 0x06000595 RID: 1429
	[Token(Token = "0x170002FB")]
	float inWaterBlend { [Token(Token = "0x6000595")] get; }

	// Token: 0x170002FC RID: 764
	// (get) Token: 0x06000596 RID: 1430
	[Token(Token = "0x170002FC")]
	float spineBlendX { [Token(Token = "0x6000596")] get; }

	// Token: 0x170002FD RID: 765
	// (get) Token: 0x06000597 RID: 1431
	[Token(Token = "0x170002FD")]
	bool drinkWater { [Token(Token = "0x6000597")] get; }

	// Token: 0x170002FE RID: 766
	// (get) Token: 0x06000598 RID: 1432
	// (set) Token: 0x06000599 RID: 1433
	[Token(Token = "0x170002FE")]
	int PlayerVariationBody { [Token(Token = "0x6000598")] get; [Token(Token = "0x6000599")] set; }

	// Token: 0x170002FF RID: 767
	// (get) Token: 0x0600059A RID: 1434
	[Token(Token = "0x170002FF")]
	int turnLegInt { [Token(Token = "0x600059A")] get; }

	// Token: 0x17000300 RID: 768
	// (get) Token: 0x0600059B RID: 1435
	[Token(Token = "0x17000300")]
	bool blockColdBool { [Token(Token = "0x600059B")] get; }

	// Token: 0x17000301 RID: 769
	// (get) Token: 0x0600059C RID: 1436
	[Token(Token = "0x17000301")]
	bool spearThrowBool { [Token(Token = "0x600059C")] get; }

	// Token: 0x17000302 RID: 770
	// (get) Token: 0x0600059D RID: 1437
	[Token(Token = "0x17000302")]
	NetworkArray_Integer ClothWeapons { [Token(Token = "0x600059D")] get; }

	// Token: 0x17000303 RID: 771
	// (get) Token: 0x0600059E RID: 1438
	// (set) Token: 0x0600059F RID: 1439
	[Token(Token = "0x17000303")]
	bool Rebreater { [Token(Token = "0x600059E")] get; [Token(Token = "0x600059F")] set; }

	// Token: 0x17000304 RID: 772
	// (get) Token: 0x060005A0 RID: 1440
	// (set) Token: 0x060005A1 RID: 1441
	[Token(Token = "0x17000304")]
	int ArmSkin { [Token(Token = "0x60005A0")] get; [Token(Token = "0x60005A1")] set; }

	// Token: 0x17000305 RID: 773
	// (get) Token: 0x060005A2 RID: 1442
	[Token(Token = "0x17000305")]
	bool dragAwayBool { [Token(Token = "0x60005A2")] get; }

	// Token: 0x17000306 RID: 774
	// (get) Token: 0x060005A3 RID: 1443
	// (set) Token: 0x060005A4 RID: 1444
	[Token(Token = "0x17000306")]
	int Layer0Hash { [Token(Token = "0x60005A3")] get; [Token(Token = "0x60005A4")] set; }

	// Token: 0x17000307 RID: 775
	// (get) Token: 0x060005A5 RID: 1445
	// (set) Token: 0x060005A6 RID: 1446
	[Token(Token = "0x17000307")]
	int Layer1Hash { [Token(Token = "0x60005A5")] get; [Token(Token = "0x60005A6")] set; }

	// Token: 0x17000308 RID: 776
	// (get) Token: 0x060005A7 RID: 1447
	// (set) Token: 0x060005A8 RID: 1448
	[Token(Token = "0x17000308")]
	int Layer2Hash { [Token(Token = "0x60005A7")] get; [Token(Token = "0x60005A8")] set; }

	// Token: 0x17000309 RID: 777
	// (get) Token: 0x060005A9 RID: 1449
	// (set) Token: 0x060005AA RID: 1450
	[Token(Token = "0x17000309")]
	int Layer3Hash { [Token(Token = "0x60005A9")] get; [Token(Token = "0x60005AA")] set; }

	// Token: 0x1700030A RID: 778
	// (get) Token: 0x060005AB RID: 1451
	[Token(Token = "0x1700030A")]
	bool lightWeaponBool { [Token(Token = "0x60005AB")] get; }

	// Token: 0x1700030B RID: 779
	// (get) Token: 0x060005AC RID: 1452
	[Token(Token = "0x1700030B")]
	bool resetClimbBool { [Token(Token = "0x60005AC")] get; }

	// Token: 0x1700030C RID: 780
	// (get) Token: 0x060005AD RID: 1453
	[Token(Token = "0x1700030C")]
	bool clampSpine { [Token(Token = "0x60005AD")] get; }

	// Token: 0x1700030D RID: 781
	// (get) Token: 0x060005AE RID: 1454
	[Token(Token = "0x1700030D")]
	bool bookHeld { [Token(Token = "0x60005AE")] get; }

	// Token: 0x1700030E RID: 782
	// (get) Token: 0x060005AF RID: 1455
	[Token(Token = "0x1700030E")]
	int bookCloseInt { [Token(Token = "0x60005AF")] get; }

	// Token: 0x1700030F RID: 783
	// (get) Token: 0x060005B0 RID: 1456
	[Token(Token = "0x1700030F")]
	NetworkTransform RaftTransform { [Token(Token = "0x60005B0")] get; }

	// Token: 0x17000310 RID: 784
	// (get) Token: 0x060005B1 RID: 1457
	// (set) Token: 0x060005B2 RID: 1458
	[Token(Token = "0x17000310")]
	BoltEntity RaftEntity { [Token(Token = "0x60005B1")] get; [Token(Token = "0x60005B2")] set; }

	// Token: 0x060005B3 RID: 1459
	[Token(Token = "0x60005B3")]
	void knockBackTrigger();

	// Token: 0x060005B4 RID: 1460
	[Token(Token = "0x60005B4")]
	void deathTrigger();

	// Token: 0x060005B5 RID: 1461
	[Token(Token = "0x60005B5")]
	void resetTrigger();

	// Token: 0x060005B6 RID: 1462
	[Token(Token = "0x60005B6")]
	void cancelBowTrigger();

	// Token: 0x060005B7 RID: 1463
	[Token(Token = "0x60005B7")]
	void injuredTrigger();

	// Token: 0x060005B8 RID: 1464
	[Token(Token = "0x60005B8")]
	void setClimbTrigger();

	// Token: 0x060005B9 RID: 1465
	[Token(Token = "0x60005B9")]
	void setClimbTopTrigger();

	// Token: 0x060005BA RID: 1466
	[Token(Token = "0x60005BA")]
	void resetClimbTrigger();
}
