using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[Serializable]
	public class ItemIdObject<T> where T : UnityEngine.Object
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000AB")]
		public T GetObject()
		{
			return null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x60000AC")]
		public int GetItemId()
		{
			return 0;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		public ItemIdObject()
		{
		}

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int _itemId;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T _target;
	}
}
