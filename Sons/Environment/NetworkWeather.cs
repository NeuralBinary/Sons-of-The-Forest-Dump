using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200064F RID: 1615
	[Token(Token = "0x200064F")]
	[AddComponentMenu("Sons/Multiplayer/Client/NetworkWeather")]
	public class NetworkWeather : EntityBehaviour<IWeatherState>, IWindReceiver, ICloudReceiver
	{
		// Token: 0x060029BF RID: 10687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BF")]
		[Address(RVA = "0x33F0650", Offset = "0x33EEC50", VA = "0x1833F0650")]
		public void Update()
		{
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C0")]
		[Address(RVA = "0x33F0980", Offset = "0x33EEF80", VA = "0x1833F0980", Slot = "24")]
		public void UpdateWind(Vector3 direction, float intensity)
		{
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x60029C1")]
		[Address(RVA = "0x33F0B90", Offset = "0x33EF190", VA = "0x1833F0B90")]
		private bool IsAttached()
		{
			return default(bool);
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		[Token(Token = "0x60029C2")]
		[Address(RVA = "0x33F0C80", Offset = "0x33EF280", VA = "0x1833F0C80")]
		private bool IsAttachedOwner()
		{
			return default(bool);
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C3")]
		[Address(RVA = "0x33F0D90", Offset = "0x33EF390", VA = "0x1833F0D90", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C4")]
		[Address(RVA = "0x33F15A0", Offset = "0x33EFBA0", VA = "0x1833F15A0", Slot = "17")]
		public override void Detached()
		{
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C5")]
		[Address(RVA = "0x33F1620", Offset = "0x33EFC20", VA = "0x1833F1620")]
		private void OnRainTypeChanged()
		{
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C6")]
		[Address(RVA = "0x33F1800", Offset = "0x33EFE00", VA = "0x1833F1800")]
		private void OnCloudStateChanged()
		{
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C7")]
		[Address(RVA = "0x33F19A0", Offset = "0x33EFFA0", VA = "0x1833F19A0")]
		private void OnTargetStormFactorChanged()
		{
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C8")]
		[Address(RVA = "0x33F1B40", Offset = "0x33F0140", VA = "0x1833F1B40")]
		private void OnWindChanged()
		{
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x33F1FA0", Offset = "0x33F05A0", VA = "0x1833F1FA0", Slot = "25")]
		public void UpdateCloud(float density)
		{
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x33F2050", Offset = "0x33F0650", VA = "0x1833F2050")]
		public NetworkWeather()
		{
		}

		// Token: 0x0400252F RID: 9519
		[Token(Token = "0x400252F")]
		[FieldOffset(Offset = "0x28")]
		private bool _isServer;
	}
}
