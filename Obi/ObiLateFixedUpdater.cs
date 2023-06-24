using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	[ExecuteInEditMode]
	[AddComponentMenu("Physics/Obi/Obi Late Fixed Updater", 802)]
	public class ObiLateFixedUpdater : ObiUpdater
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x27F2140", Offset = "0x27F0740", VA = "0x1827F2140")]
		private void OnValidate()
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x27F2160", Offset = "0x27F0760", VA = "0x1827F2160")]
		private void Awake()
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x27F24F0", Offset = "0x27F0AF0", VA = "0x1827F24F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x27F2520", Offset = "0x27F0B20", VA = "0x1827F2520")]
		private void OnDisable()
		{
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x27F2550", Offset = "0x27F0B50", VA = "0x1827F2550")]
		private IEnumerator RunLateFixedUpdate()
		{
			return null;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x27F2220", Offset = "0x27F0820", VA = "0x1827F2220")]
		private void LateFixedUpdate()
		{
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x27F23D0", Offset = "0x27F09D0", VA = "0x1827F23D0")]
		private void Update()
		{
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x27F25E0", Offset = "0x27F0BE0", VA = "0x1827F25E0")]
		public ObiLateFixedUpdater()
		{
		}

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of substeps performed per FixedUpdate. Increasing the amount of substeps greatly improves accuracy and convergence speed.")]
		public int substeps;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x2C")]
		private float accumulatedTime;
	}
}
