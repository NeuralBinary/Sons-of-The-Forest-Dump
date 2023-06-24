using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003F RID: 63
[Token(Token = "0x200003F")]
public interface IPlayerState : IWorldCharacter, IState, IDisposable
{
	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x0600017F RID: 383
	// (set) Token: 0x06000180 RID: 384
	[Token(Token = "0x170000A8")]
	int PlayerRace { [Token(Token = "0x600017F")] get; [Token(Token = "0x6000180")] set; }

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06000181 RID: 385
	[Token(Token = "0x170000A9")]
	NetworkArray_Integer HeldItems { [Token(Token = "0x6000181")] get; }

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000182 RID: 386
	[Token(Token = "0x170000AA")]
	NetworkArray_Integer PlayerClothingIds { [Token(Token = "0x6000182")] get; }

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000183 RID: 387
	[Token(Token = "0x170000AB")]
	NetworkArray_Integer PlayerArmourIds { [Token(Token = "0x6000183")] get; }

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06000184 RID: 388
	// (set) Token: 0x06000185 RID: 389
	[Token(Token = "0x170000AC")]
	int PlayerVariationHair { [Token(Token = "0x6000184")] get; [Token(Token = "0x6000185")] set; }

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000186 RID: 390
	// (set) Token: 0x06000187 RID: 391
	[Token(Token = "0x170000AD")]
	float hSpeed { [Token(Token = "0x6000186")] get; [Token(Token = "0x6000187")] set; }

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000188 RID: 392
	// (set) Token: 0x06000189 RID: 393
	[Token(Token = "0x170000AE")]
	int itemAtFeet { [Token(Token = "0x6000188")] get; [Token(Token = "0x6000189")] set; }

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x0600018A RID: 394
	// (set) Token: 0x0600018B RID: 395
	[Token(Token = "0x170000AF")]
	float vSpeed { [Token(Token = "0x600018A")] get; [Token(Token = "0x600018B")] set; }

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x0600018C RID: 396
	[Token(Token = "0x170000B0")]
	float overallSpeed { [Token(Token = "0x600018C")] get; }

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x0600018D RID: 397
	[Token(Token = "0x170000B1")]
	float weaponHit { [Token(Token = "0x600018D")] get; }

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x0600018E RID: 398
	[Token(Token = "0x170000B2")]
	float normCamX { [Token(Token = "0x600018E")] get; }

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x0600018F RID: 399
	[Token(Token = "0x170000B3")]
	float normCamY { [Token(Token = "0x600018F")] get; }

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06000190 RID: 400
	// (set) Token: 0x06000191 RID: 401
	[Token(Token = "0x170000B4")]
	float spineBlendX { [Token(Token = "0x6000190")] get; [Token(Token = "0x6000191")] set; }

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06000192 RID: 402
	[Token(Token = "0x170000B5")]
	float tiredFloat { [Token(Token = "0x6000192")] get; }

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06000193 RID: 403
	[Token(Token = "0x170000B6")]
	float aimAtTarget { [Token(Token = "0x6000193")] get; }

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000194 RID: 404
	[Token(Token = "0x170000B7")]
	float crouch { [Token(Token = "0x6000194")] get; }

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000195 RID: 405
	[Token(Token = "0x170000B8")]
	float groundHeight { [Token(Token = "0x6000195")] get; }

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000196 RID: 406
	[Token(Token = "0x170000B9")]
	bool logHeld { [Token(Token = "0x6000196")] get; }

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000197 RID: 407
	// (set) Token: 0x06000198 RID: 408
	[Token(Token = "0x170000BA")]
	int HeldOnlyItemId { [Token(Token = "0x6000197")] get; [Token(Token = "0x6000198")] set; }

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x06000199 RID: 409
	// (set) Token: 0x0600019A RID: 410
	[Token(Token = "0x170000BB")]
	int HeldOnlyItemCount { [Token(Token = "0x6000199")] get; [Token(Token = "0x600019A")] set; }

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x0600019B RID: 411
	[Token(Token = "0x170000BC")]
	float coldFloat { [Token(Token = "0x600019B")] get; }

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x0600019C RID: 412
	[Token(Token = "0x170000BD")]
	float inWaterBlend { [Token(Token = "0x600019C")] get; }

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x0600019D RID: 413
	[Token(Token = "0x170000BE")]
	bool bodyHeld { [Token(Token = "0x600019D")] get; }

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x0600019E RID: 414
	[Token(Token = "0x170000BF")]
	NetworkTransform Transform { [Token(Token = "0x600019E")] get; }

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x0600019F RID: 415
	// (set) Token: 0x060001A0 RID: 416
	[Token(Token = "0x170000C0")]
	string name { [Token(Token = "0x600019F")] get; [Token(Token = "0x60001A0")] set; }

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x060001A1 RID: 417
	// (set) Token: 0x060001A2 RID: 418
	[Token(Token = "0x170000C1")]
	int CurrentView { [Token(Token = "0x60001A1")] get; [Token(Token = "0x60001A2")] set; }

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060001A3 RID: 419
	// (set) Token: 0x060001A4 RID: 420
	[Token(Token = "0x170000C2")]
	bool FX_Fire { [Token(Token = "0x60001A3")] get; [Token(Token = "0x60001A4")] set; }

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060001A5 RID: 421
	[Token(Token = "0x170000C3")]
	NetworkArray_Integer MapPieces { [Token(Token = "0x60001A5")] get; }

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060001A6 RID: 422
	[Token(Token = "0x170000C4")]
	NetworkArray_Integer ClothWeapons { [Token(Token = "0x60001A6")] get; }

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x060001A7 RID: 423
	// (set) Token: 0x060001A8 RID: 424
	[Token(Token = "0x170000C5")]
	bool Bloody { [Token(Token = "0x60001A7")] get; [Token(Token = "0x60001A8")] set; }

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060001A9 RID: 425
	// (set) Token: 0x060001AA RID: 426
	[Token(Token = "0x170000C6")]
	bool Muddy { [Token(Token = "0x60001A9")] get; [Token(Token = "0x60001AA")] set; }

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060001AB RID: 427
	// (set) Token: 0x060001AC RID: 428
	[Token(Token = "0x170000C7")]
	bool Cold { [Token(Token = "0x60001AB")] get; [Token(Token = "0x60001AC")] set; }

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060001AD RID: 429
	[Token(Token = "0x170000C8")]
	NetworkTransform RaftTransform { [Token(Token = "0x60001AD")] get; }

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060001AE RID: 430
	// (set) Token: 0x060001AF RID: 431
	[Token(Token = "0x170000C9")]
	BoltEntity RaftEntity { [Token(Token = "0x60001AE")] get; [Token(Token = "0x60001AF")] set; }

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060001B0 RID: 432
	// (set) Token: 0x060001B1 RID: 433
	[Token(Token = "0x170000CA")]
	Action OnknockBackTrigger { [Token(Token = "0x60001B0")] get; [Token(Token = "0x60001B1")] set; }

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060001B2 RID: 434
	// (set) Token: 0x060001B3 RID: 435
	[Token(Token = "0x170000CB")]
	bool ShowLoadedAmmo { [Token(Token = "0x60001B2")] get; [Token(Token = "0x60001B3")] set; }

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x060001B4 RID: 436
	// (set) Token: 0x060001B5 RID: 437
	[Token(Token = "0x170000CC")]
	float TreeDensity { [Token(Token = "0x60001B4")] get; [Token(Token = "0x60001B5")] set; }

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x060001B6 RID: 438
	[Token(Token = "0x170000CD")]
	NetworkArray_Integer WeaponUpgrades { [Token(Token = "0x60001B6")] get; }

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x060001B7 RID: 439
	// (set) Token: 0x060001B8 RID: 440
	[Token(Token = "0x170000CE")]
	bool MolotovFire { [Token(Token = "0x60001B7")] get; [Token(Token = "0x60001B8")] set; }

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x060001B9 RID: 441
	// (set) Token: 0x060001BA RID: 442
	[Token(Token = "0x170000CF")]
	bool DynamiteFire { [Token(Token = "0x60001B9")] get; [Token(Token = "0x60001BA")] set; }

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x060001BB RID: 443
	// (set) Token: 0x060001BC RID: 444
	[Token(Token = "0x170000D0")]
	bool isTargetting { [Token(Token = "0x60001BB")] get; [Token(Token = "0x60001BC")] set; }

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x060001BD RID: 445
	[Token(Token = "0x170000D1")]
	NetworkArray_Objects<ItemInfo> SharableStorage { [Token(Token = "0x60001BD")] get; }

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x060001BE RID: 446
	[Token(Token = "0x170000D2")]
	float axeBlend1 { [Token(Token = "0x60001BE")] get; }

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x060001BF RID: 447
	[Token(Token = "0x170000D3")]
	float terrainAngle { [Token(Token = "0x60001BF")] get; }

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x060001C0 RID: 448
	[Token(Token = "0x170000D4")]
	float singleArmBlock { [Token(Token = "0x60001C0")] get; }

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x060001C1 RID: 449
	// (set) Token: 0x060001C2 RID: 450
	[Token(Token = "0x170000D5")]
	bool inWater { [Token(Token = "0x60001C1")] get; [Token(Token = "0x60001C2")] set; }

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x060001C3 RID: 451
	// (set) Token: 0x060001C4 RID: 452
	[Token(Token = "0x170000D6")]
	bool onRaft { [Token(Token = "0x60001C3")] get; [Token(Token = "0x60001C4")] set; }

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x060001C5 RID: 453
	// (set) Token: 0x060001C6 RID: 454
	[Token(Token = "0x170000D7")]
	bool IsWaitingToSleep { [Token(Token = "0x60001C5")] get; [Token(Token = "0x60001C6")] set; }

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x060001C7 RID: 455
	// (set) Token: 0x060001C8 RID: 456
	[Token(Token = "0x170000D8")]
	Color PlayerColor { [Token(Token = "0x60001C7")] get; [Token(Token = "0x60001C8")] set; }

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060001C9 RID: 457
	[Token(Token = "0x170000D9")]
	NetworkArray_Integer QuickSelectItemIds { [Token(Token = "0x60001C9")] get; }

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060001CA RID: 458
	[Token(Token = "0x170000DA")]
	float climbSpeed { [Token(Token = "0x60001CA")] get; }

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060001CB RID: 459
	// (set) Token: 0x060001CC RID: 460
	[Token(Token = "0x170000DB")]
	int UnderfootSurface { [Token(Token = "0x60001CB")] get; [Token(Token = "0x60001CC")] set; }

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x060001CD RID: 461
	// (set) Token: 0x060001CE RID: 462
	[Token(Token = "0x170000DC")]
	bool UnderfootGore { [Token(Token = "0x60001CD")] get; [Token(Token = "0x60001CE")] set; }

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060001CF RID: 463
	[Token(Token = "0x170000DD")]
	bool zipLineAttach { [Token(Token = "0x60001CF")] get; }

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060001D0 RID: 464
	// (set) Token: 0x060001D1 RID: 465
	[Token(Token = "0x170000DE")]
	int LoopingEventPath { [Token(Token = "0x60001D0")] get; [Token(Token = "0x60001D1")] set; }

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x060001D2 RID: 466
	// (set) Token: 0x060001D3 RID: 467
	[Token(Token = "0x170000DF")]
	Vector3 LoopingEventPosition { [Token(Token = "0x60001D2")] get; [Token(Token = "0x60001D3")] set; }

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060001D4 RID: 468
	[Token(Token = "0x170000E0")]
	float shellBlend { [Token(Token = "0x60001D4")] get; }

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x060001D5 RID: 469
	// (set) Token: 0x060001D6 RID: 470
	[Token(Token = "0x170000E1")]
	bool arrowFire { [Token(Token = "0x60001D5")] get; [Token(Token = "0x60001D6")] set; }

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x060001D7 RID: 471
	[Token(Token = "0x170000E2")]
	bool clampSpine { [Token(Token = "0x60001D7")] get; }

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x060001D8 RID: 472
	// (set) Token: 0x060001D9 RID: 473
	[Token(Token = "0x170000E3")]
	int SpearedFishType { [Token(Token = "0x60001D8")] get; [Token(Token = "0x60001D9")] set; }

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x060001DA RID: 474
	[Token(Token = "0x170000E4")]
	float bowSpeed { [Token(Token = "0x60001DA")] get; }

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x060001DB RID: 475
	// (set) Token: 0x060001DC RID: 476
	[Token(Token = "0x170000E5")]
	bool RightHandItemIsLit { [Token(Token = "0x60001DB")] get; [Token(Token = "0x60001DC")] set; }

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x060001DD RID: 477
	[Token(Token = "0x170000E6")]
	NetworkTransform HeadVR { [Token(Token = "0x60001DD")] get; }

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060001DE RID: 478
	[Token(Token = "0x170000E7")]
	NetworkTransform RightHandVR { [Token(Token = "0x60001DE")] get; }

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060001DF RID: 479
	[Token(Token = "0x170000E8")]
	NetworkTransform LeftHandVR { [Token(Token = "0x60001DF")] get; }

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060001E0 RID: 480
	// (set) Token: 0x060001E1 RID: 481
	[Token(Token = "0x170000E9")]
	bool VREnabled { [Token(Token = "0x60001E0")] get; [Token(Token = "0x60001E1")] set; }

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060001E2 RID: 482
	[Token(Token = "0x170000EA")]
	int RightHandHeldItemId { [Token(Token = "0x60001E2")] get; }

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060001E3 RID: 483
	// (set) Token: 0x060001E4 RID: 484
	[Token(Token = "0x170000EB")]
	bool rightHandActive { [Token(Token = "0x60001E3")] get; [Token(Token = "0x60001E4")] set; }

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x060001E5 RID: 485
	// (set) Token: 0x060001E6 RID: 486
	[Token(Token = "0x170000EC")]
	bool HeadIsUnderwater { [Token(Token = "0x60001E5")] get; [Token(Token = "0x60001E6")] set; }

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x060001E7 RID: 487
	// (set) Token: 0x060001E8 RID: 488
	[Token(Token = "0x170000ED")]
	int caveMask { [Token(Token = "0x60001E7")] get; [Token(Token = "0x60001E8")] set; }

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060001E9 RID: 489
	// (set) Token: 0x060001EA RID: 490
	[Token(Token = "0x170000EE")]
	int Dying { [Token(Token = "0x60001E9")] get; [Token(Token = "0x60001EA")] set; }

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x060001EB RID: 491
	[Token(Token = "0x170000EF")]
	NetworkArray_Objects<HeldItemWeaponMods> HeldItemsWeaponMods { [Token(Token = "0x60001EB")] get; }

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x060001EC RID: 492
	// (set) Token: 0x060001ED RID: 493
	[Token(Token = "0x170000F0")]
	int StimuliFlags { [Token(Token = "0x60001EC")] get; [Token(Token = "0x60001ED")] set; }

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x060001EE RID: 494
	// (set) Token: 0x060001EF RID: 495
	[Token(Token = "0x170000F1")]
	float VisibilityRangeMult { [Token(Token = "0x60001EE")] get; [Token(Token = "0x60001EF")] set; }

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x060001F0 RID: 496
	// (set) Token: 0x060001F1 RID: 497
	[Token(Token = "0x170000F2")]
	int TiedUpState { [Token(Token = "0x60001F0")] get; [Token(Token = "0x60001F1")] set; }

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x060001F2 RID: 498
	// (set) Token: 0x060001F3 RID: 499
	[Token(Token = "0x170000F3")]
	int MarkerHash { [Token(Token = "0x60001F2")] get; [Token(Token = "0x60001F3")] set; }

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x060001F4 RID: 500
	// (set) Token: 0x060001F5 RID: 501
	[Token(Token = "0x170000F4")]
	bool IsInMidAction { [Token(Token = "0x60001F4")] get; [Token(Token = "0x60001F5")] set; }

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x060001F6 RID: 502
	// (set) Token: 0x060001F7 RID: 503
	[Token(Token = "0x170000F5")]
	bool HasBackpack { [Token(Token = "0x60001F6")] get; [Token(Token = "0x60001F7")] set; }

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x060001F8 RID: 504
	[Token(Token = "0x170000F6")]
	PerishableItemInstanceModuleBoltData HeldItemPerishableState { [Token(Token = "0x60001F8")] get; }

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x060001F9 RID: 505
	// (set) Token: 0x060001FA RID: 506
	[Token(Token = "0x170000F7")]
	bool TactiPenHeld { [Token(Token = "0x60001F9")] get; [Token(Token = "0x60001FA")] set; }

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x060001FB RID: 507
	// (set) Token: 0x060001FC RID: 508
	[Token(Token = "0x170000F8")]
	bool TactiPadHeld { [Token(Token = "0x60001FB")] get; [Token(Token = "0x60001FC")] set; }

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x060001FD RID: 509
	[Token(Token = "0x170000F9")]
	StoredItemsData StoringItems { [Token(Token = "0x60001FD")] get; }

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x060001FE RID: 510
	// (set) Token: 0x060001FF RID: 511
	[Token(Token = "0x170000FA")]
	int Expression { [Token(Token = "0x60001FE")] get; [Token(Token = "0x60001FF")] set; }

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000200 RID: 512
	// (set) Token: 0x06000201 RID: 513
	[Token(Token = "0x170000FB")]
	bool DisableBodyColliders { [Token(Token = "0x6000200")] get; [Token(Token = "0x6000201")] set; }

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000202 RID: 514
	// (set) Token: 0x06000203 RID: 515
	[Token(Token = "0x170000FC")]
	int StandUpProps { [Token(Token = "0x6000202")] get; [Token(Token = "0x6000203")] set; }

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000204 RID: 516
	[Token(Token = "0x170000FD")]
	float treeHeightBlend { [Token(Token = "0x6000204")] get; }

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000205 RID: 517
	// (set) Token: 0x06000206 RID: 518
	[Token(Token = "0x170000FE")]
	int HeldScrewStructureID { [Token(Token = "0x6000205")] get; [Token(Token = "0x6000206")] set; }

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000207 RID: 519
	[Token(Token = "0x170000FF")]
	HeldItemSlotTransfer HeldItemEquipSlotTransfer { [Token(Token = "0x6000207")] get; }

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000208 RID: 520
	[Token(Token = "0x17000100")]
	float RideLeanRightLeft { [Token(Token = "0x6000208")] get; }

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000209 RID: 521
	[Token(Token = "0x17000101")]
	float RideLeanForwardBack { [Token(Token = "0x6000209")] get; }

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x0600020A RID: 522
	[Token(Token = "0x17000102")]
	NetworkTransform ConnectedTransform { [Token(Token = "0x600020A")] get; }

	// Token: 0x0600020B RID: 523
	[Token(Token = "0x600020B")]
	void knockBackTrigger();
}
