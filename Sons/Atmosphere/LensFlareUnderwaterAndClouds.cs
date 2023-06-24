using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x020005E2 RID: 1506
	[Token(Token = "0x20005E2")]
	public class LensFlareUnderwaterAndClouds : MonoBehaviour, ICloudReceiver
	{
		// Token: 0x06002718 RID: 10008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002718")]
		[Address(RVA = "0x33BB580", Offset = "0x33B9B80", VA = "0x1833BB580")]
		private void OnValidate()
		{
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002719")]
		[Address(RVA = "0x33BB6B0", Offset = "0x33B9CB0", VA = "0x1833BB6B0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271A")]
		[Address(RVA = "0x33BBA70", Offset = "0x33BA070", VA = "0x1833BBA70")]
		private void OnDisable()
		{
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271B")]
		[Address(RVA = "0x33BBE30", Offset = "0x33BA430", VA = "0x1833BBE30")]
		private void RequestFade()
		{
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271C")]
		[Address(RVA = "0x33BBF10", Offset = "0x33BA510", VA = "0x1833BBF10")]
		private void UnrequestFade()
		{
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271D")]
		[Address(RVA = "0x33BC000", Offset = "0x33BA600", VA = "0x1833BC000")]
		private void OnUnderWater()
		{
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271E")]
		[Address(RVA = "0x33BC010", Offset = "0x33BA610", VA = "0x1833BC010")]
		public void OnAboveWater()
		{
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271F")]
		[Address(RVA = "0x33BC020", Offset = "0x33BA620", VA = "0x1833BC020", Slot = "4")]
		public void UpdateCloud(float density)
		{
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002720")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LensFlareUnderwaterAndClouds()
		{
		}

		// Token: 0x04002338 RID: 9016
		[Token(Token = "0x4002338")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LensFlareFader _lensFlareFader;

		// Token: 0x04002339 RID: 9017
		[Token(Token = "0x4002339")]
		[FieldOffset(Offset = "0x28")]
		private bool _cloudRequestedFade;

		// Token: 0x0400233A RID: 9018
		[Token(Token = "0x400233A")]
		[FieldOffset(Offset = "0x29")]
		private bool _waterRequestedFade;

		// Token: 0x0400233B RID: 9019
		[Token(Token = "0x400233B")]
		[FieldOffset(Offset = "0x2A")]
		private bool _requestedFade;
	}
}
