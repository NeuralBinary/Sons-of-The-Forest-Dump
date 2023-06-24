using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008F9 RID: 2297
	[Token(Token = "0x20008F9")]
	[AddComponentMenu("Sons/Animation/ApplyAnimationPose")]
	public class ApplyAnimationPose : MonoBehaviour
	{
		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06004236 RID: 16950 RVA: 0x000141A8 File Offset: 0x000123A8
		[Token(Token = "0x17000850")]
		public int callbackOrder
		{
			[Token(Token = "0x6004236")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004237")]
		[Address(RVA = "0x3633180", Offset = "0x3631780", VA = "0x183633180")]
		public ApplyAnimationPose()
		{
		}

		// Token: 0x04004594 RID: 17812
		[Token(Token = "0x4004594")]
		private const string IgnoreTagString = "Ignore";

		// Token: 0x04004595 RID: 17813
		[Token(Token = "0x4004595")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<AnimationClipSnapshot> _snapshots;

		// Token: 0x04004596 RID: 17814
		[Token(Token = "0x4004596")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> _skipFromBindPose;

		// Token: 0x04004597 RID: 17815
		[Token(Token = "0x4004597")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<ApplyAnimationPose.LinkedObjectTransform> _bindPose;

		// Token: 0x04004598 RID: 17816
		[Token(Token = "0x4004598")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ApplyAnimationPose.LinkedObjectTransform> _storedPose;

		// Token: 0x04004599 RID: 17817
		[Token(Token = "0x4004599")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ApplyAnimationPose _switchToPoser;

		// Token: 0x020008FA RID: 2298
		[Token(Token = "0x20008FA")]
		[Serializable]
		public class LinkedObjectTransform
		{
			// Token: 0x17000851 RID: 2129
			// (get) Token: 0x06004238 RID: 16952 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004239 RID: 16953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000851")]
			public Transform Target
			{
				[Token(Token = "0x6004238")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004239")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000852 RID: 2130
			// (get) Token: 0x0600423A RID: 16954 RVA: 0x000141C0 File Offset: 0x000123C0
			// (set) Token: 0x0600423B RID: 16955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000852")]
			public Vector3 Position
			{
				[Token(Token = "0x600423A")]
				[Address(RVA = "0xA6DCA0", Offset = "0xA6C2A0", VA = "0x180A6DCA0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600423B")]
				[Address(RVA = "0x1676010", Offset = "0x1674610", VA = "0x181676010")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000853 RID: 2131
			// (get) Token: 0x0600423C RID: 16956 RVA: 0x000141D8 File Offset: 0x000123D8
			// (set) Token: 0x0600423D RID: 16957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000853")]
			public Quaternion Rotation
			{
				[Token(Token = "0x600423C")]
				[Address(RVA = "0xA6DCC0", Offset = "0xA6C2C0", VA = "0x180A6DCC0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600423D")]
				[Address(RVA = "0x720740", Offset = "0x71ED40", VA = "0x180720740")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000854 RID: 2132
			// (get) Token: 0x0600423E RID: 16958 RVA: 0x000141F0 File Offset: 0x000123F0
			// (set) Token: 0x0600423F RID: 16959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000854")]
			public Vector3 Scale
			{
				[Token(Token = "0x600423E")]
				[Address(RVA = "0x781540", Offset = "0x77FB40", VA = "0x180781540")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600423F")]
				[Address(RVA = "0x781560", Offset = "0x77FB60", VA = "0x180781560")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06004240 RID: 16960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004240")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public LinkedObjectTransform()
			{
			}
		}
	}
}
