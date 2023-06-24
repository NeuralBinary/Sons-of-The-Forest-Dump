using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public static class BipedNaming
	{
		// Token: 0x0600006C RID: 108 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x28E52A0", Offset = "0x28E38A0", VA = "0x1828E52A0")]
		public static Transform[] GetBonesOfType(BipedNaming.BoneType boneType, Transform[] bones)
		{
			return null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x28E5490", Offset = "0x28E3A90", VA = "0x1828E5490")]
		public static Transform[] GetBonesOfSide(BipedNaming.BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x28E5680", Offset = "0x28E3C80", VA = "0x1828E5680")]
		public static Transform[] GetBonesOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x28E56F0", Offset = "0x28E3CF0", VA = "0x1828E56F0")]
		public static Transform GetFirstBoneOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x28E5790", Offset = "0x28E3D90", VA = "0x1828E5790")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x28E5960", Offset = "0x28E3F60", VA = "0x1828E5960")]
		public static BipedNaming.BoneType GetBoneType(string boneName)
		{
			return BipedNaming.BoneType.Unassigned;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x28E5AB0", Offset = "0x28E40B0", VA = "0x1828E5AB0")]
		public static BipedNaming.BoneSide GetBoneSide(string boneName)
		{
			return BipedNaming.BoneSide.Center;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x28E5B30", Offset = "0x28E4130", VA = "0x1828E5B30")]
		public static Transform GetBone(Transform[] transforms, BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide = BipedNaming.BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x28E5BC0", Offset = "0x28E41C0", VA = "0x1828E5BC0")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x28E5E50", Offset = "0x28E4450", VA = "0x1828E5E50")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x28E60E0", Offset = "0x28E46E0", VA = "0x1828E60E0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x28E62A0", Offset = "0x28E48A0", VA = "0x1828E62A0")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x28E6460", Offset = "0x28E4A60", VA = "0x1828E6460")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x28E6620", Offset = "0x28E4C20", VA = "0x1828E6620")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x28E67E0", Offset = "0x28E4DE0", VA = "0x1828E67E0")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x28E69A0", Offset = "0x28E4FA0", VA = "0x1828E69A0")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x28E6B60", Offset = "0x28E5160", VA = "0x1828E6B60")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x28E6CA0", Offset = "0x28E52A0", VA = "0x1828E6CA0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x28E6DB0", Offset = "0x28E53B0", VA = "0x1828E6DB0")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x28E6E30", Offset = "0x28E5430", VA = "0x1828E6E30")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x28E6F30", Offset = "0x28E5530", VA = "0x1828E6F30")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x28E6FA0", Offset = "0x28E55A0", VA = "0x1828E6FA0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x28E7000", Offset = "0x28E5600", VA = "0x1828E7000")]
		private static string lastLetter(string boneName)
		{
			return null;
		}

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x80")]
		public static string[] hand;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x88")]
		public static string[] foot;

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		[Serializable]
		public enum BoneType
		{
			// Token: 0x040000A2 RID: 162
			[Token(Token = "0x40000A2")]
			Unassigned,
			// Token: 0x040000A3 RID: 163
			[Token(Token = "0x40000A3")]
			Spine,
			// Token: 0x040000A4 RID: 164
			[Token(Token = "0x40000A4")]
			Head,
			// Token: 0x040000A5 RID: 165
			[Token(Token = "0x40000A5")]
			Arm,
			// Token: 0x040000A6 RID: 166
			[Token(Token = "0x40000A6")]
			Leg,
			// Token: 0x040000A7 RID: 167
			[Token(Token = "0x40000A7")]
			Tail,
			// Token: 0x040000A8 RID: 168
			[Token(Token = "0x40000A8")]
			Eye
		}

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		[Serializable]
		public enum BoneSide
		{
			// Token: 0x040000AA RID: 170
			[Token(Token = "0x40000AA")]
			Center,
			// Token: 0x040000AB RID: 171
			[Token(Token = "0x40000AB")]
			Left,
			// Token: 0x040000AC RID: 172
			[Token(Token = "0x40000AC")]
			Right
		}
	}
}
