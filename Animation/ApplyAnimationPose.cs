using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000887 RID: 2183
	[Token(Token = "0x2000887")]
	[AddComponentMenu("Sons/Animation/ApplyAnimationPose")]
	public class ApplyAnimationPose : MonoBehaviour
	{
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06003B0A RID: 15114 RVA: 0x00011310 File Offset: 0x0000F510
		[Token(Token = "0x1700072B")]
		public int callbackOrder
		{
			[Token(Token = "0x6003B0A")]
			[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0B")]
		[Address(RVA = "0x2EF9700", Offset = "0x2EF8700", VA = "0x182EF9700")]
		public ApplyAnimationPose()
		{
		}

		// Token: 0x04003F69 RID: 16233
		[Token(Token = "0x4003F69")]
		private const string IgnoreTagString = "Ignore";

		// Token: 0x04003F6A RID: 16234
		[Token(Token = "0x4003F6A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<AnimationClipSnapshot> _snapshots;

		// Token: 0x04003F6B RID: 16235
		[Token(Token = "0x4003F6B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> _skipFromBindPose;

		// Token: 0x04003F6C RID: 16236
		[Token(Token = "0x4003F6C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<ApplyAnimationPose.LinkedObjectTransform> _bindPose;

		// Token: 0x04003F6D RID: 16237
		[Token(Token = "0x4003F6D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ApplyAnimationPose.LinkedObjectTransform> _storedPose;

		// Token: 0x04003F6E RID: 16238
		[Token(Token = "0x4003F6E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ApplyAnimationPose _switchToPoser;

		// Token: 0x02000888 RID: 2184
		[Token(Token = "0x2000888")]
		[Serializable]
		public class LinkedObjectTransform
		{
			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x06003B0C RID: 15116 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003B0D RID: 15117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700072C")]
			public Transform Target
			{
				[Token(Token = "0x6003B0C")]
				[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003B0D")]
				[Address(RVA = "0x5A85D0", Offset = "0x5A75D0", VA = "0x1805A85D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x06003B0E RID: 15118 RVA: 0x00011328 File Offset: 0x0000F528
			// (set) Token: 0x06003B0F RID: 15119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700072D")]
			public Vector3 Position
			{
				[Token(Token = "0x6003B0E")]
				[Address(RVA = "0x909E10", Offset = "0x908E10", VA = "0x180909E10")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6003B0F")]
				[Address(RVA = "0x143A810", Offset = "0x1439810", VA = "0x18143A810")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x06003B10 RID: 15120 RVA: 0x00011340 File Offset: 0x0000F540
			// (set) Token: 0x06003B11 RID: 15121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700072E")]
			public Quaternion Rotation
			{
				[Token(Token = "0x6003B10")]
				[Address(RVA = "0x909E30", Offset = "0x908E30", VA = "0x180909E30")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6003B11")]
				[Address(RVA = "0x681040", Offset = "0x680040", VA = "0x180681040")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x06003B12 RID: 15122 RVA: 0x00011358 File Offset: 0x0000F558
			// (set) Token: 0x06003B13 RID: 15123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700072F")]
			public Vector3 Scale
			{
				[Token(Token = "0x6003B12")]
				[Address(RVA = "0x6C5520", Offset = "0x6C4520", VA = "0x1806C5520")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6003B13")]
				[Address(RVA = "0x6C5580", Offset = "0x6C4580", VA = "0x1806C5580")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06003B14 RID: 15124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B14")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public LinkedObjectTransform()
			{
			}
		}
	}
}
