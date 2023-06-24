using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public class ObjectWaterInteractionAdaptor : FloatingObjectBase
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x1700001F")]
		public override float ObjectWidth
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x17000020")]
		public override bool InWater
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x9D8F80", Offset = "0x9D7580", VA = "0x1809D8F80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x17000021")]
		public override Vector3 Velocity
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x9D9070", Offset = "0x9D7670", VA = "0x1809D9070", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x9D90E0", Offset = "0x9D76E0", VA = "0x1809D90E0")]
		private void Update()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x9D9710", Offset = "0x9D7D10", VA = "0x1809D9710")]
		public ObjectWaterInteractionAdaptor()
		{
		}

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x20")]
		private Vector3[] _queryPoints;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x28")]
		private Vector3[] _resultDisps;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x30")]
		private float _height;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 _velocity;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _lastPos;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x4C")]
		private bool _hasWaterData;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x4D")]
		private bool _hasVelocity;
	}
}
