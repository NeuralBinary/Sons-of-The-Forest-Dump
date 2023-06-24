using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[AddComponentMenu("Sons/Gui/DaysSurvivedTextMesh")]
	public class DaysSurvivedTextMesh : AutoUpdateTextMesh
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x3000910", Offset = "0x2FFEF10", VA = "0x183000910", Slot = "4")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x3000F80", Offset = "0x2FFF580", VA = "0x183000F80")]
		private string GetDaysString()
		{
			return null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
		public override bool CanUpdate()
		{
			return default(bool);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x3000FB0", Offset = "0x2FFF5B0", VA = "0x183000FB0")]
		private void Update()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x30012A0", Offset = "0x2FFF8A0", VA = "0x1830012A0")]
		private void Initialize()
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x3001420", Offset = "0x2FFFA20", VA = "0x183001420")]
		public DaysSurvivedTextMesh()
		{
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _cycleTime;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _delay;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x40")]
		private TimeSpan _timeSpan;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x48")]
		private int _lastDayValue;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x4C")]
		private int _lastHourValue;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x50")]
		private int _lastMinValue;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x54")]
		private int _lastSecondValue;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x58")]
		private bool _finalResult;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x59")]
		private bool _initialized;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x5C")]
		private float _startTime;
	}
}
