using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x02000745 RID: 1861
	[Token(Token = "0x2000745")]
	[AddComponentMenu("Sons/Multiplayer/Client/NetworkWeather")]
	public class NetworkWeather : EntityBehaviour<IWeatherState>, IWindReceiver, ICloudReceiver
	{
		// Token: 0x06003064 RID: 12388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003064")]
		[Address(RVA = "0x2E36490", Offset = "0x2E35490", VA = "0x182E36490")]
		public void Update()
		{
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003065")]
		[Address(RVA = "0x2E36300", Offset = "0x2E35300", VA = "0x182E36300", Slot = "24")]
		public void UpdateWind(Vector3 direction, float intensity)
		{
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[Token(Token = "0x6003066")]
		[Address(RVA = "0x2E35C40", Offset = "0x2E34C40", VA = "0x182E35C40")]
		private bool IsAttached()
		{
			return default(bool);
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		[Token(Token = "0x6003067")]
		[Address(RVA = "0x2E35B90", Offset = "0x2E34B90", VA = "0x182E35B90")]
		private bool IsAttachedOwner()
		{
			return default(bool);
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003068")]
		[Address(RVA = "0x2E35760", Offset = "0x2E34760", VA = "0x182E35760", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003069")]
		[Address(RVA = "0x2E35B10", Offset = "0x2E34B10", VA = "0x182E35B10", Slot = "17")]
		public override void Detached()
		{
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306A")]
		[Address(RVA = "0x2E35D90", Offset = "0x2E34D90", VA = "0x182E35D90")]
		private void OnRainTypeChanged()
		{
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306B")]
		[Address(RVA = "0x2E35CD0", Offset = "0x2E34CD0", VA = "0x182E35CD0")]
		private void OnCloudStateChanged()
		{
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306C")]
		[Address(RVA = "0x2E35EE0", Offset = "0x2E34EE0", VA = "0x182E35EE0")]
		private void OnTargetStormFactorChanged()
		{
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306D")]
		[Address(RVA = "0x2E35FA0", Offset = "0x2E34FA0", VA = "0x182E35FA0")]
		private void OnWindChanged()
		{
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306E")]
		[Address(RVA = "0x2E36280", Offset = "0x2E35280", VA = "0x182E36280", Slot = "25")]
		public void UpdateCloud(float density)
		{
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306F")]
		[Address(RVA = "0x2E36730", Offset = "0x2E35730", VA = "0x182E36730")]
		public NetworkWeather()
		{
		}

		// Token: 0x04002A69 RID: 10857
		[Token(Token = "0x4002A69")]
		[FieldOffset(Offset = "0x28")]
		private bool _isServer;
	}
}
