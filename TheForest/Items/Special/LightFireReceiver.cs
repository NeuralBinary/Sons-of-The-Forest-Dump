using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Interfaces;
using UnityEngine;

namespace TheForest.Items.Special
{
	// Token: 0x020004AA RID: 1194
	[Token(Token = "0x20004AA")]
	[Serializable]
	public class LightFireReceiver : ILightFireReceiver
	{
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000433")]
		public ILightableFire Target
		{
			[Token(Token = "0x6001E4D")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E4E")]
			[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4F")]
		[Address(RVA = "0x2D128F0", Offset = "0x2D118F0", VA = "0x182D128F0", Slot = "5")]
		public void Initiate(ILightableFire fire)
		{
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E50")]
		[Address(RVA = "0x2D12990", Offset = "0x2D11990", VA = "0x182D12990", Slot = "6")]
		public void OnLeanForwardEnter()
		{
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x2D12A50", Offset = "0x2D11A50", VA = "0x182D12A50", Slot = "7")]
		public void OnLeanForwardLightLeavesUp()
		{
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x2D12AA0", Offset = "0x2D11AA0", VA = "0x182D12AA0", Slot = "8")]
		public void OnLeanForwardThrowLeaves()
		{
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x2D12AB0", Offset = "0x2D11AB0", VA = "0x182D12AB0", Slot = "9")]
		public void OnLeanForwardToLight()
		{
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x2D124C0", Offset = "0x2D114C0", VA = "0x182D124C0", Slot = "10")]
		public void OnLeanForwardExit()
		{
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x2D124C0", Offset = "0x2D114C0", VA = "0x182D124C0", Slot = "11")]
		public void Cancel()
		{
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x2D126B0", Offset = "0x2D116B0", VA = "0x182D126B0")]
		private void InitLeaves()
		{
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x2D12610", Offset = "0x2D11610", VA = "0x182D12610")]
		private void ClearLeaves()
		{
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public LightFireReceiver()
		{
		}

		// Token: 0x04001C6C RID: 7276
		[Token(Token = "0x4001C6C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _lightFireLeavesPrefab;

		// Token: 0x04001C6D RID: 7277
		[Token(Token = "0x4001C6D")]
		[FieldOffset(Offset = "0x18")]
		private GameObject _leavesInstance;
	}
}
