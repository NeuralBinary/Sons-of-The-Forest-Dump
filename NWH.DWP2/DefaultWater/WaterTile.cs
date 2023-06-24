using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.DefaultWater
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		// Token: 0x06000288 RID: 648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2731510", Offset = "0x272FB10", VA = "0x182731510")]
		public void Start()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2731520", Offset = "0x272FB20", VA = "0x182731520")]
		private void AcquireComponents()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2731C50", Offset = "0x2730250", VA = "0x182731C50")]
		public void OnWillRenderObject()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WaterTile()
		{
		}

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x20")]
		public PlanarReflection reflection;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x28")]
		public WaterBase waterBase;
	}
}
