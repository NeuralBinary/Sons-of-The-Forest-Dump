using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000087 RID: 135
[Token(Token = "0x2000087")]
public interface IMecanimVailActorState : IWorldCharacter, IState, IDisposable
{
	// Token: 0x17000243 RID: 579
	// (get) Token: 0x06000480 RID: 1152
	[Token(Token = "0x17000243")]
	NetworkTransform Transform { [Token(Token = "0x6000480")] get; }

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x06000481 RID: 1153
	// (set) Token: 0x06000482 RID: 1154
	[Token(Token = "0x17000244")]
	int BloodMask { [Token(Token = "0x6000481")] get; [Token(Token = "0x6000482")] set; }

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x06000483 RID: 1155
	// (set) Token: 0x06000484 RID: 1156
	[Token(Token = "0x17000245")]
	int VailState { [Token(Token = "0x6000483")] get; [Token(Token = "0x6000484")] set; }

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x06000485 RID: 1157
	// (set) Token: 0x06000486 RID: 1158
	[Token(Token = "0x17000246")]
	int VariationSeed { [Token(Token = "0x6000485")] get; [Token(Token = "0x6000486")] set; }

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x06000487 RID: 1159
	// (set) Token: 0x06000488 RID: 1160
	[Token(Token = "0x17000247")]
	int Ragdoll { [Token(Token = "0x6000487")] get; [Token(Token = "0x6000488")] set; }

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x06000489 RID: 1161
	// (set) Token: 0x0600048A RID: 1162
	[Token(Token = "0x17000248")]
	float Direction { [Token(Token = "0x6000489")] get; [Token(Token = "0x600048A")] set; }

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x0600048B RID: 1163
	// (set) Token: 0x0600048C RID: 1164
	[Token(Token = "0x17000249")]
	float DirectionX { [Token(Token = "0x600048B")] get; [Token(Token = "0x600048C")] set; }

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x0600048D RID: 1165
	// (set) Token: 0x0600048E RID: 1166
	[Token(Token = "0x1700024A")]
	float DirectionZ { [Token(Token = "0x600048D")] get; [Token(Token = "0x600048E")] set; }

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x0600048F RID: 1167
	// (set) Token: 0x06000490 RID: 1168
	[Token(Token = "0x1700024B")]
	int OutfitId { [Token(Token = "0x600048F")] get; [Token(Token = "0x6000490")] set; }

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x06000491 RID: 1169
	// (set) Token: 0x06000492 RID: 1170
	[Token(Token = "0x1700024C")]
	int DismemberMask { [Token(Token = "0x6000491")] get; [Token(Token = "0x6000492")] set; }

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x06000493 RID: 1171
	// (set) Token: 0x06000494 RID: 1172
	[Token(Token = "0x1700024D")]
	float ArmorLevel { [Token(Token = "0x6000493")] get; [Token(Token = "0x6000494")] set; }

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x06000495 RID: 1173
	// (set) Token: 0x06000496 RID: 1174
	[Token(Token = "0x1700024E")]
	bool Burning { [Token(Token = "0x6000495")] get; [Token(Token = "0x6000496")] set; }

	// Token: 0x1700024F RID: 591
	// (get) Token: 0x06000497 RID: 1175
	// (set) Token: 0x06000498 RID: 1176
	[Token(Token = "0x1700024F")]
	bool InCave { [Token(Token = "0x6000497")] get; [Token(Token = "0x6000498")] set; }

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x06000499 RID: 1177
	// (set) Token: 0x0600049A RID: 1178
	[Token(Token = "0x17000250")]
	Vector3 RagdollPosition { [Token(Token = "0x6000499")] get; [Token(Token = "0x600049A")] set; }

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x0600049B RID: 1179
	// (set) Token: 0x0600049C RID: 1180
	[Token(Token = "0x17000251")]
	int VariationSubSet { [Token(Token = "0x600049B")] get; [Token(Token = "0x600049C")] set; }

	// Token: 0x17000252 RID: 594
	// (get) Token: 0x0600049D RID: 1181
	// (set) Token: 0x0600049E RID: 1182
	[Token(Token = "0x17000252")]
	bool Skinned { [Token(Token = "0x600049D")] get; [Token(Token = "0x600049E")] set; }

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x0600049F RID: 1183
	// (set) Token: 0x060004A0 RID: 1184
	[Token(Token = "0x17000253")]
	int Expression { [Token(Token = "0x600049F")] get; [Token(Token = "0x60004A0")] set; }

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x060004A1 RID: 1185
	// (set) Token: 0x060004A2 RID: 1186
	[Token(Token = "0x17000254")]
	int EquippedMask { [Token(Token = "0x60004A1")] get; [Token(Token = "0x60004A2")] set; }

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x060004A3 RID: 1187
	// (set) Token: 0x060004A4 RID: 1188
	[Token(Token = "0x17000255")]
	int ItemCarryTypeCount { [Token(Token = "0x60004A3")] get; [Token(Token = "0x60004A4")] set; }

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x060004A5 RID: 1189
	// (set) Token: 0x060004A6 RID: 1190
	[Token(Token = "0x17000256")]
	int PlayerSentimentLevel { [Token(Token = "0x60004A5")] get; [Token(Token = "0x60004A6")] set; }

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x060004A7 RID: 1191
	// (set) Token: 0x060004A8 RID: 1192
	[Token(Token = "0x17000257")]
	bool BodyBurning { [Token(Token = "0x60004A7")] get; [Token(Token = "0x60004A8")] set; }

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x060004A9 RID: 1193
	// (set) Token: 0x060004AA RID: 1194
	[Token(Token = "0x17000258")]
	int GpsLocatorId { [Token(Token = "0x60004A9")] get; [Token(Token = "0x60004AA")] set; }

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x060004AB RID: 1195
	// (set) Token: 0x060004AC RID: 1196
	[Token(Token = "0x17000259")]
	float Wetness { [Token(Token = "0x60004AB")] get; [Token(Token = "0x60004AC")] set; }

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x060004AD RID: 1197
	// (set) Token: 0x060004AE RID: 1198
	[Token(Token = "0x1700025A")]
	bool HelicopterHeld { [Token(Token = "0x60004AD")] get; [Token(Token = "0x60004AE")] set; }
}
