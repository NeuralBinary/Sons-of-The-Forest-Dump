using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public abstract class Grounder : MonoBehaviour
	{
		// Token: 0x0600015B RID: 347
		[Token(Token = "0x600015B")]
		public abstract void ResetPosition();

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00002D5C File Offset: 0x00000F5C
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x28FD200", Offset = "0x28FB800", VA = "0x1828FD200")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x28F7760", Offset = "0x28F5D60", VA = "0x1828F7760")]
		protected void LogWarning(string message)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x28FD350", Offset = "0x28FB950", VA = "0x1828FD350")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x28FD5C0", Offset = "0x28FBBC0", VA = "0x1828FD5C0")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		// Token: 0x06000162 RID: 354
		[Token(Token = "0x6000162")]
		protected abstract void OpenUserManual();

		// Token: 0x06000163 RID: 355
		[Token(Token = "0x6000163")]
		protected abstract void OpenScriptReference();

		// Token: 0x06000164 RID: 356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x28FD870", Offset = "0x28FBE70", VA = "0x1828FD870")]
		protected Grounder()
		{
		}

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x30")]
		public Grounder.GrounderDelegate OnPreGrounder;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x38")]
		public Grounder.GrounderDelegate OnPostGrounder;

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000166 RID: 358
		[Token(Token = "0x2000035")]
		public delegate void GrounderDelegate();
	}
}
