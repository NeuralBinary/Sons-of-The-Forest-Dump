using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.DefaultWater
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class SpecularLighting : MonoBehaviour
	{
		// Token: 0x06000277 RID: 631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x272CB00", Offset = "0x272B100", VA = "0x18272CB00")]
		public void Start()
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x272CD40", Offset = "0x272B340", VA = "0x18272CD40")]
		public void Update()
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SpecularLighting()
		{
		}

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x20")]
		public Transform specularLight;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x28")]
		private WaterBase m_WaterBase;
	}
}
