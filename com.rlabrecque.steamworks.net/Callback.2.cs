using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	public sealed class Callback<T> : Callback, IDisposable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000890 RID: 2192 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000891 RID: 2193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		private event Callback<T>.DispatchDelegate m_Func
		{
			[Token(Token = "0x6000890")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000891")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000892")]
		public static Callback<T> Create(Callback<T>.DispatchDelegate func)
		{
			return null;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000893")]
		public static Callback<T> CreateGameServer(Callback<T>.DispatchDelegate func)
		{
			return null;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000894")]
		public Callback(Callback<T>.DispatchDelegate func, bool bGameServer = false)
		{
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000895")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000896")]
		public void Dispose()
		{
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000897")]
		public void Register(Callback<T>.DispatchDelegate func)
		{
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000898")]
		public void Unregister()
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x00007B44 File Offset: 0x00005D44
		[Token(Token = "0x17000022")]
		public override bool IsGameServer
		{
			[Token(Token = "0x6000899")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600089A")]
		internal override Type GetCallbackType()
		{
			return null;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089B")]
		internal override void OnRunCallback(IntPtr pvParam)
		{
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089C")]
		internal override void SetUnregistered()
		{
		}

		// Token: 0x040009EF RID: 2543
		[Token(Token = "0x40009EF")]
		[FieldOffset(Offset = "0x0")]
		private bool m_bGameServer;

		// Token: 0x040009F0 RID: 2544
		[Token(Token = "0x40009F0")]
		[FieldOffset(Offset = "0x0")]
		private bool m_bIsRegistered;

		// Token: 0x040009F1 RID: 2545
		[Token(Token = "0x40009F1")]
		[FieldOffset(Offset = "0x0")]
		private bool m_bDisposed;

		// Token: 0x0200017B RID: 379
		// (Invoke) Token: 0x0600089E RID: 2206
		[Token(Token = "0x200017B")]
		public delegate void DispatchDelegate(T param);
	}
}
