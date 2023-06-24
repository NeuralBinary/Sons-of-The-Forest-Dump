using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	[AddComponentMenu("Physics/Obi/Obi Fixed Updater", 801)]
	[ExecuteInEditMode]
	public class ObiFixedUpdater : ObiUpdater
	{
		// Token: 0x06000860 RID: 2144 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x27F2140", Offset = "0x27F0740", VA = "0x1827F2140")]
		private void OnValidate()
		{
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x27F2160", Offset = "0x27F0760", VA = "0x1827F2160")]
		private void Awake()
		{
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x27F2170", Offset = "0x27F0770", VA = "0x1827F2170")]
		private void OnDisable()
		{
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x27F2220", Offset = "0x27F0820", VA = "0x1827F2220")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x27F23D0", Offset = "0x27F09D0", VA = "0x1827F23D0")]
		private void Update()
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x27F24A0", Offset = "0x27F0AA0", VA = "0x1827F24A0")]
		public ObiFixedUpdater()
		{
		}

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of substeps performed per FixedUpdate. Increasing the amount of substeps greatly improves accuracy and convergence speed.")]
		public int substeps;

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x2C")]
		private float accumulatedTime;
	}
}
