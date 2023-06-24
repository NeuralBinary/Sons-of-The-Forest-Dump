using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[Serializable]
	public abstract class ShaderGlobalValue<T>
	{
		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		protected ShaderGlobalValue(int nameId, T defaultValue)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		internal void UpdateChanged()
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		private void UpdateChanged(int nameId, T sourceValue, ref T cacheValue)
		{
		}

		// Token: 0x060001B0 RID: 432
		[Token(Token = "0x60001B0")]
		public abstract void SetGlobal(int nameId, T sourceValue);

		// Token: 0x060001B1 RID: 433
		[Token(Token = "0x60001B1")]
		public abstract bool IsUnchanged();

		// Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B2")]
		protected static void UpdateArray<PT, PU>(List<PT> value) where PT : ShaderGlobalValue<PU>
		{
		}

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected T _value;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string _shaderNameId;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x0")]
		protected T _cacheValue;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x0")]
		private int? _shaderValueNameId;
	}
}
