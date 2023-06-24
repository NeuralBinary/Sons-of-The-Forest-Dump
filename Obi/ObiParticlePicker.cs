using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Obi
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	public class ObiParticlePicker : MonoBehaviour
	{
		// Token: 0x060008DF RID: 2271 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x27FBEF0", Offset = "0x27FA4F0", VA = "0x1827FBEF0")]
		private void Awake()
		{
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x27FBF60", Offset = "0x27FA560", VA = "0x1827FBF60")]
		private void LateUpdate()
		{
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x27FD170", Offset = "0x27FB770", VA = "0x1827FD170")]
		public ObiParticlePicker()
		{
		}

		// Token: 0x0400076B RID: 1899
		[Token(Token = "0x400076B")]
		[FieldOffset(Offset = "0x20")]
		public ObiSolver solver;

		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x28")]
		public float radiusScale;

		// Token: 0x0400076D RID: 1901
		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x30")]
		public ObiParticlePicker.ParticlePickUnityEvent OnParticlePicked;

		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		[FieldOffset(Offset = "0x38")]
		public ObiParticlePicker.ParticlePickUnityEvent OnParticleHeld;

		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		[FieldOffset(Offset = "0x40")]
		public ObiParticlePicker.ParticlePickUnityEvent OnParticleDragged;

		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0x48")]
		public ObiParticlePicker.ParticlePickUnityEvent OnParticleReleased;

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 lastMousePos;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x5C")]
		private int pickedParticleIndex;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x60")]
		private float pickedParticleDepth;

		// Token: 0x020001C9 RID: 457
		[Token(Token = "0x20001C9")]
		public class ParticlePickEventArgs : EventArgs
		{
			// Token: 0x060008E2 RID: 2274 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x27FD200", Offset = "0x27FB800", VA = "0x1827FD200")]
			public ParticlePickEventArgs(int particleIndex, Vector3 worldPosition)
			{
			}

			// Token: 0x04000774 RID: 1908
			[Token(Token = "0x4000774")]
			[FieldOffset(Offset = "0x10")]
			public int particleIndex;

			// Token: 0x04000775 RID: 1909
			[Token(Token = "0x4000775")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 worldPosition;
		}

		// Token: 0x020001CA RID: 458
		[Token(Token = "0x20001CA")]
		[Serializable]
		public class ParticlePickUnityEvent : UnityEvent<ObiParticlePicker.ParticlePickEventArgs>
		{
			// Token: 0x060008E3 RID: 2275 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x27FD270", Offset = "0x27FB870", VA = "0x1827FD270")]
			public ParticlePickUnityEvent()
			{
			}
		}
	}
}
