using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[AddComponentMenu("Sons/Utils/EnableTimedToggle")]
	public class EnableTimedToggle : MonoBehaviour
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		[Address(RVA = "0xA72270", Offset = "0xA70870", VA = "0x180A72270")]
		private void Start()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000102")]
		[Address(RVA = "0xA72330", Offset = "0xA70930", VA = "0x180A72330")]
		private IEnumerator EnableWorker(float delay)
		{
			return null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void Update()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x6BC7C0", Offset = "0x6BADC0", VA = "0x1806BC7C0")]
		public EnableTimedToggle()
		{
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _targetsA;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _targetsB;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _startDelay;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _toggleCount;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _toggleInterval;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x3C")]
		private int _toggleCountdown;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x40")]
		private bool _state;
	}
}
