using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007F1 RID: 2033
	[Token(Token = "0x20007F1")]
	public class TreeRegrowChecker : MonoBehaviour, ISleepingReceiver
	{
		// Token: 0x060036FF RID: 14079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x35370C0", Offset = "0x35356C0", VA = "0x1835370C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003700")]
		[Address(RVA = "0x3537110", Offset = "0x3535710", VA = "0x183537110")]
		private void OnDisable()
		{
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003701")]
		[Address(RVA = "0x3537160", Offset = "0x3535760", VA = "0x183537160", Slot = "4")]
		public void OnWentToSleep()
		{
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003702")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void OnWokeUp()
		{
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003703")]
		[Address(RVA = "0x35372D0", Offset = "0x35358D0", VA = "0x1835372D0")]
		public TreeRegrowChecker()
		{
		}

		// Token: 0x04002F79 RID: 12153
		[Token(Token = "0x4002F79")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _regrowthFactor;

		// Token: 0x04002F7A RID: 12154
		[Token(Token = "0x4002F7A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _minRegrowTreesPerCheck;

		// Token: 0x04002F7B RID: 12155
		[Token(Token = "0x4002F7B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _maxRegrowTreesPerCheck;

		// Token: 0x04002F7C RID: 12156
		[Token(Token = "0x4002F7C")]
		[FieldOffset(Offset = "0x2C")]
		private int _lastRegrowCount;

		// Token: 0x04002F7D RID: 12157
		[Token(Token = "0x4002F7D")]
		[FieldOffset(Offset = "0x30")]
		private int _totalValidTreesFound;

		// Token: 0x04002F7E RID: 12158
		[Token(Token = "0x4002F7E")]
		[FieldOffset(Offset = "0x34")]
		private int _lastRegrowFrame;
	}
}
