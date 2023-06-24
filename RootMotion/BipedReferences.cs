using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[Serializable]
	public class BipedReferences
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x28E8870", Offset = "0x28E6E70", VA = "0x1828E8870", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x28E9230", Offset = "0x28E7830", VA = "0x1828E9230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x28E9250", Offset = "0x28E7850", VA = "0x1828E9250", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x28E9C10", Offset = "0x28E8210", VA = "0x1828E9C10", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x28EAA00", Offset = "0x28E9000", VA = "0x1828EAA00")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x28EADB0", Offset = "0x28E93B0", VA = "0x1828EADB0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x28EBCF0", Offset = "0x28EA2F0", VA = "0x1828EBCF0")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, BipedReferences.AutoDetectParams autoDetectParams)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x28EC750", Offset = "0x28EAD50", VA = "0x1828EC750")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x28EC8D0", Offset = "0x28EAED0", VA = "0x1828EC8D0")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x28EC9C0", Offset = "0x28EAFC0", VA = "0x1828EC9C0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x28ECC20", Offset = "0x28EB220", VA = "0x1828ECC20")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x28ECDF0", Offset = "0x28EB3F0", VA = "0x1828ECDF0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x28ED200", Offset = "0x28EB800", VA = "0x1828ED200")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x28ED4D0", Offset = "0x28EBAD0", VA = "0x1828ED4D0")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x28ED600", Offset = "0x28EBC00", VA = "0x1828ED600")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x28EDEA0", Offset = "0x28EC4A0", VA = "0x1828EDEA0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x28EE2B0", Offset = "0x28EC8B0", VA = "0x1828EE2B0")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x28EE820", Offset = "0x28ECE20", VA = "0x1828EE820")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x28EEAC0", Offset = "0x28ED0C0", VA = "0x1828EEAC0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x28EEFF0", Offset = "0x28ED5F0", VA = "0x1828EEFF0")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x28EF4C0", Offset = "0x28EDAC0", VA = "0x1828EF4C0")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return 0f;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x28EF5C0", Offset = "0x28EDBC0", VA = "0x1828EF5C0")]
		public BipedReferences()
		{
		}

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x10")]
		public Transform root;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x80")]
		public Transform head;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x2000019")]
		public struct AutoDetectParams
		{
			// Token: 0x0600009C RID: 156 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x28EF6D0", Offset = "0x28EDCD0", VA = "0x1828EF6D0")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600009D RID: 157 RVA: 0x00002594 File Offset: 0x00000794
			[Token(Token = "0x1700000C")]
			public static BipedReferences.AutoDetectParams Default
			{
				[Token(Token = "0x600009D")]
				[Address(RVA = "0x28EF6E0", Offset = "0x28EDCE0", VA = "0x1828EF6E0")]
				get
				{
					return default(BipedReferences.AutoDetectParams);
				}
			}

			// Token: 0x040000BE RID: 190
			[Token(Token = "0x40000BE")]
			[FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			// Token: 0x040000BF RID: 191
			[Token(Token = "0x40000BF")]
			[FieldOffset(Offset = "0x1")]
			public bool includeEyes;
		}
	}
}
