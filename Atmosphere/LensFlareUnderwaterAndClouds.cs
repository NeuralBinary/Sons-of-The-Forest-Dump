using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x020005D1 RID: 1489
	[Token(Token = "0x20005D1")]
	public class LensFlareUnderwaterAndClouds : MonoBehaviour, ICloudReceiver
	{
		// Token: 0x0600260F RID: 9743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260F")]
		[Address(RVA = "0x2DA5A50", Offset = "0x2DA4A50", VA = "0x182DA5A50")]
		private void OnValidate()
		{
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002610")]
		[Address(RVA = "0x2DA5870", Offset = "0x2DA4870", VA = "0x182DA5870")]
		private void OnEnable()
		{
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002611")]
		[Address(RVA = "0x2DA56A0", Offset = "0x2DA46A0", VA = "0x182DA56A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002612")]
		[Address(RVA = "0x2DA5AF0", Offset = "0x2DA4AF0", VA = "0x182DA5AF0")]
		private void RequestFade()
		{
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002613")]
		[Address(RVA = "0x2DA5B80", Offset = "0x2DA4B80", VA = "0x182DA5B80")]
		private void UnrequestFade()
		{
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002614")]
		[Address(RVA = "0x2DA5A40", Offset = "0x2DA4A40", VA = "0x182DA5A40")]
		private void OnUnderWater()
		{
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x2DA5610", Offset = "0x2DA4610", VA = "0x182DA5610")]
		public void OnAboveWater()
		{
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x2DA5C10", Offset = "0x2DA4C10", VA = "0x182DA5C10", Slot = "4")]
		public void UpdateCloud(float density)
		{
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LensFlareUnderwaterAndClouds()
		{
		}

		// Token: 0x0400225A RID: 8794
		[Token(Token = "0x400225A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LensFlareFader _lensFlareFader;

		// Token: 0x0400225B RID: 8795
		[Token(Token = "0x400225B")]
		[FieldOffset(Offset = "0x28")]
		private bool _cloudRequestedFade;

		// Token: 0x0400225C RID: 8796
		[Token(Token = "0x400225C")]
		[FieldOffset(Offset = "0x29")]
		private bool _waterRequestedFade;

		// Token: 0x0400225D RID: 8797
		[Token(Token = "0x400225D")]
		[FieldOffset(Offset = "0x2A")]
		private bool _requestedFade;
	}
}
