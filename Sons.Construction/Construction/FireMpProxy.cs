using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001ED RID: 493
	[Token(Token = "0x20001ED")]
	[AddComponentMenu("Sons/Construction/FireMpProxy")]
	public class FireMpProxy : EntityBehaviour<IFireState>
	{
		// Token: 0x06000ECD RID: 3789 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x2EF2EE0", Offset = "0x2EF14E0", VA = "0x182EF2EE0")]
		public static FireMpProxy Create(CookingFireNew fire)
		{
			return null;
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x2EF32D0", Offset = "0x2EF18D0", VA = "0x182EF32D0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x2EF3860", Offset = "0x2EF1E60", VA = "0x182EF3860")]
		private void Update()
		{
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x2EF3870", Offset = "0x2EF1E70", VA = "0x182EF3870")]
		private void StructureInfoChanged()
		{
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x2EF3D40", Offset = "0x2EF2340", VA = "0x182EF3D40")]
		private void FuelChanged()
		{
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x2EF3F50", Offset = "0x2EF2550", VA = "0x182EF3F50")]
		private void LitChanged()
		{
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x2EF40A0", Offset = "0x2EF26A0", VA = "0x182EF40A0")]
		private void OnCookingStateChanged()
		{
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x2EF4360", Offset = "0x2EF2960", VA = "0x182EF4360")]
		public void SendLightFireAction()
		{
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x2EF43C0", Offset = "0x2EF29C0", VA = "0x182EF43C0")]
		public void SendStokeFireAction()
		{
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x2EF4420", Offset = "0x2EF2A20", VA = "0x182EF4420")]
		public void SetLitStatus(bool isLit, float fuel)
		{
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x2EF4520", Offset = "0x2EF2B20", VA = "0x182EF4520")]
		public void ReceiveLightFireAction()
		{
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x2EF4600", Offset = "0x2EF2C00", VA = "0x182EF4600")]
		public void ReceiveStokeFireAction()
		{
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x2EF46E0", Offset = "0x2EF2CE0", VA = "0x182EF46E0")]
		public void ReceiveCookOnFireAction(ItemInstance itemInstance)
		{
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x2EF47D0", Offset = "0x2EF2DD0", VA = "0x182EF47D0")]
		public void ReceiveIsBusy(bool isBusy)
		{
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x2EF4800", Offset = "0x2EF2E00", VA = "0x182EF4800")]
		public void ReceiveBeginCooking(int recipeId)
		{
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x2EF4970", Offset = "0x2EF2F70", VA = "0x182EF4970")]
		public void ReceivedPotRemoved()
		{
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x2EF49C0", Offset = "0x2EF2FC0", VA = "0x182EF49C0")]
		public void ReceivedUpdateVolume(float amount)
		{
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x2EF4AE0", Offset = "0x2EF30E0", VA = "0x182EF4AE0")]
		public FireMpProxy()
		{
		}

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x28")]
		private CookingFireNew _fire;
	}
}
