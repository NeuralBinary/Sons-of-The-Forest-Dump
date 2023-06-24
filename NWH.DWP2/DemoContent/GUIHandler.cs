using System;
using Il2CppDummyDll;
using NWH.DWP2.ShipController;
using UnityEngine;
using UnityEngine.UI;

namespace NWH.DWP2.DemoContent
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	public class GUIHandler : MonoBehaviour
	{
		// Token: 0x0600028C RID: 652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2731FF0", Offset = "0x27305F0", VA = "0x182731FF0")]
		private void Update()
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2732470", Offset = "0x2730A70", VA = "0x182732470")]
		public void ResetScene()
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public GUIHandler()
		{
		}

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x20")]
		public Text speedText;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x28")]
		public Text rudderText;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x30")]
		public Image anchorImage;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x38")]
		public bool reset;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x40")]
		private AdvancedShipController activeShip;
	}
}
