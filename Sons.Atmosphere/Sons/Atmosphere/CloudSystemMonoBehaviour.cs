using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public abstract class CloudSystemMonoBehaviour : MonoBehaviour, ICloudReceiver
	{
		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public virtual void AssignLight(Light sourceLight)
		{
		}

		// Token: 0x06000147 RID: 327
		[Token(Token = "0x6000147")]
		public abstract void UpdateCloud(float density);

		// Token: 0x06000148 RID: 328
		[Token(Token = "0x6000148")]
		public abstract void SwitchToRandomProfile();

		// Token: 0x06000149 RID: 329
		[Token(Token = "0x6000149")]
		public abstract void SwitchToProfile(string name);

		// Token: 0x0600014A RID: 330
		[Token(Token = "0x600014A")]
		public abstract void SwitchToProfile(int index);

		// Token: 0x0600014B RID: 331
		[Token(Token = "0x600014B")]
		public abstract void UpdateWind(Vector3 direction, float intensity);

		// Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected CloudSystemMonoBehaviour()
		{
		}
	}
}
