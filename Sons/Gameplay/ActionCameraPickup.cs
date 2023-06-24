using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000793 RID: 1939
	[Token(Token = "0x2000793")]
	[AddComponentMenu("Sons/Pickup/ActionCameraPickup")]
	public class ActionCameraPickup : PickUp
	{
		// Token: 0x06003437 RID: 13367 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		[Token(Token = "0x6003437")]
		[Address(RVA = "0x34C7B20", Offset = "0x34C6120", VA = "0x1834C7B20", Slot = "29")]
		protected override bool MainEffect()
		{
			return default(bool);
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003438")]
		[Address(RVA = "0x34C7ED0", Offset = "0x34C64D0", VA = "0x1834C7ED0")]
		public ActionCameraPickup()
		{
		}

		// Token: 0x04002D23 RID: 11555
		[Token(Token = "0x4002D23")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private string _videoClipName;
	}
}
