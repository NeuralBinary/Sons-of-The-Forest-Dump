using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[AddComponentMenu("Sons/Gui/InputTypeOrderProvider")]
	public class InputTypeOrderProvider : MonoBehaviour, IOrderProvider
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x3007500", Offset = "0x3005B00", VA = "0x183007500")]
		private void Awake()
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x30075E0", Offset = "0x3005BE0", VA = "0x1830075E0", Slot = "4")]
		public Order GetOrder()
		{
			return Order.Default;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InputTypeOrderProvider()
		{
		}
	}
}
