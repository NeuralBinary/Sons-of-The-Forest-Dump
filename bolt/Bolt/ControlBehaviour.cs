using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public class ControlBehaviour : MonoBehaviour
	{
		// Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x8D50D0", Offset = "0x8D36D0", VA = "0x1808D50D0")]
		private void QueueStart(ControlCommandStart start)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x8D5130", Offset = "0x8D3730", VA = "0x1808D5130")]
		private void QueueShutdown(ControlCommandShutdown shutdown)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x8D5190", Offset = "0x8D3790", VA = "0x1808D5190")]
		private void Update()
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x8D5370", Offset = "0x8D3970", VA = "0x1808D5370")]
		public ControlBehaviour()
		{
		}

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x20")]
		private Queue<ControlCommand> commands;
	}
}
