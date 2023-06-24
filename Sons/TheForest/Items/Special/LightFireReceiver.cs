using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Interfaces;
using UnityEngine;

namespace TheForest.Items.Special
{
	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x20004A0")]
	[Serializable]
	public class LightFireReceiver : ILightFireReceiver
	{
		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EA0 RID: 7840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043D")]
		public ILightableFire Target
		{
			[Token(Token = "0x6001E9F")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EA0")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA1")]
		[Address(RVA = "0x32F3730", Offset = "0x32F1D30", VA = "0x1832F3730", Slot = "5")]
		public void Initiate(ILightableFire fire)
		{
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0x32F3810", Offset = "0x32F1E10", VA = "0x1832F3810", Slot = "6")]
		public void OnLeanForwardEnter()
		{
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0x32F3970", Offset = "0x32F1F70", VA = "0x1832F3970", Slot = "7")]
		public void OnLeanForwardLightLeavesUp()
		{
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0x32F39D0", Offset = "0x32F1FD0", VA = "0x1832F39D0", Slot = "8")]
		public void OnLeanForwardThrowLeaves()
		{
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0x32F39E0", Offset = "0x32F1FE0", VA = "0x1832F39E0", Slot = "9")]
		public void OnLeanForwardToLight()
		{
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x32F3A30", Offset = "0x32F2030", VA = "0x1832F3A30", Slot = "10")]
		public void OnLeanForwardExit()
		{
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x32F3A40", Offset = "0x32F2040", VA = "0x1832F3A40", Slot = "11")]
		public void Cancel()
		{
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x32F3C60", Offset = "0x32F2260", VA = "0x1832F3C60")]
		private void InitLeaves()
		{
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0x32F4050", Offset = "0x32F2650", VA = "0x1832F4050")]
		private void ClearLeaves()
		{
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EAA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LightFireReceiver()
		{
		}

		// Token: 0x04001CA2 RID: 7330
		[Token(Token = "0x4001CA2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _lightFireLeavesPrefab;

		// Token: 0x04001CA3 RID: 7331
		[Token(Token = "0x4001CA3")]
		[FieldOffset(Offset = "0x18")]
		private GameObject _leavesInstance;
	}
}
