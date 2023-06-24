using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;

namespace BoltInternal
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public abstract class NatCommunicator
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600035C RID: 860
		[Token(Token = "0x170000A5")]
		public abstract bool IsEnabled { [Token(Token = "0x600035C")] get; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600035D RID: 861
		[Token(Token = "0x170000A6")]
		public abstract IEnumerable<INatDevice> NatDevices { [Token(Token = "0x600035D")] get; }

		// Token: 0x0600035E RID: 862
		[Token(Token = "0x600035E")]
		public abstract void Enable();

		// Token: 0x0600035F RID: 863
		[Token(Token = "0x600035F")]
		public abstract void Update();

		// Token: 0x06000360 RID: 864
		[Token(Token = "0x6000360")]
		public abstract void Disable(bool async);

		// Token: 0x06000361 RID: 865
		[Token(Token = "0x6000361")]
		public abstract void OpenPort(int port);

		// Token: 0x06000362 RID: 866
		[Token(Token = "0x6000362")]
		public abstract void ClosePort(int port);

		// Token: 0x06000363 RID: 867
		[Token(Token = "0x6000363")]
		public abstract bool NextPortStatusChange(out INatDevice device, out IPortMapping mapping);

		// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected NatCommunicator()
		{
		}
	}
}
