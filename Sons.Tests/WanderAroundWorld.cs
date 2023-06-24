using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Evan;
using UnityEngine;

namespace Sons.Tests
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[Serializable]
	public class WanderAroundWorld : TestAction
	{
		// Token: 0x0600015C RID: 348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x3158D90", Offset = "0x3157390", VA = "0x183158D90")]
		public WanderAroundWorld()
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x28D8B60", Offset = "0x28D7160", VA = "0x1828D8B60")]
		public void SetContinuous(bool value)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x3158E30", Offset = "0x3157430", VA = "0x183158E30", Slot = "23")]
		public override IEnumerator RunWorker(string args)
		{
			return null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x3158EC0", Offset = "0x31574C0", VA = "0x183158EC0")]
		private IEnumerator FollowObjectRoutine(float followTimeOut)
		{
			return null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x3158F80", Offset = "0x3157580", VA = "0x183158F80")]
		private Vector3 GetNextLocation()
		{
			return default(Vector3);
		}

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x60")]
		private bool _continuous;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _totalTime;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _followTimeout;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x70")]
		private GameObject _followObject;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x78")]
		private EvanPlayer _evanPlayer;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x80")]
		private float _minValidHeight;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x84")]
		private float _runWalkInterval;
	}
}
