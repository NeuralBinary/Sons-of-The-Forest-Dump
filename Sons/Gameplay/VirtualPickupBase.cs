using System;
using Il2CppDummyDll;
using Sons.Utils;

namespace Sons.Gameplay
{
	// Token: 0x020007AC RID: 1964
	[Token(Token = "0x20007AC")]
	public abstract class VirtualPickupBase : DistanceActivationBase
	{
		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x0000FD98 File Offset: 0x0000DF98
		[Token(Token = "0x170006AF")]
		protected bool IsClient
		{
			[Token(Token = "0x60034F2")]
			[Address(RVA = "0x213CBA0", Offset = "0x213B1A0", VA = "0x18213CBA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F3")]
		[Address(RVA = "0x34D5850", Offset = "0x34D3E50", VA = "0x1834D5850", Slot = "11")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F4")]
		[Address(RVA = "0x34D5920", Offset = "0x34D3F20", VA = "0x1834D5920", Slot = "12")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F5")]
		[Address(RVA = "0x331E510", Offset = "0x331CB10", VA = "0x18331E510")]
		protected VirtualPickupBase()
		{
		}

		// Token: 0x04002DB1 RID: 11697
		[Token(Token = "0x4002DB1")]
		[FieldOffset(Offset = "0x60")]
		private bool _isClient;
	}
}
