using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Animation
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	public class LastUpdateProxy : MonoBehaviour
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xAAF910", Offset = "0xAADF10", VA = "0x180AAF910")]
		private void LateUpdate()
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xAAFBA0", Offset = "0xAAE1A0", VA = "0x180AAFBA0")]
		private void RemoveNullReceivers(List<int> nullReceiversBuffer)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xAAFD60", Offset = "0xAAE360", VA = "0x180AAFD60")]
		private void SortReceivers()
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xAAFF50", Offset = "0xAAE550", VA = "0x180AAFF50")]
		public static void SetupReceiver(ILastUpdateProxyReceiver receiver)
		{
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xAB0130", Offset = "0xAAE730", VA = "0x180AB0130")]
		public static void UnregisterReceiver(ILastUpdateProxyReceiver receiver)
		{
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xAB02E0", Offset = "0xAAE8E0", VA = "0x180AB02E0")]
		private void UnregisterReceiverInternal(ILastUpdateProxyReceiver receiver)
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xAB03A0", Offset = "0xAAE9A0", VA = "0x180AB03A0")]
		private int FindReceiverIndex(ILastUpdateProxyReceiver receiver)
		{
			return 0;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xAB0450", Offset = "0xAAEA50", VA = "0x180AB0450")]
		private void SetupReceiverInternal(ILastUpdateProxyReceiver receiver)
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xAB0540", Offset = "0xAAEB40", VA = "0x180AB0540")]
		private static void SetupInstance()
		{
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xAB0740", Offset = "0xAAED40", VA = "0x180AB0740")]
		public LastUpdateProxy()
		{
		}

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x20")]
		private List<LastUpdateProxyReceiverObject> _receivers;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x28")]
		private bool _isUnityObject;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x30")]
		private UnityEngine.Object _receiverUnityObject;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x0")]
		private static LastUpdateProxy _instance;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x38")]
		private List<int> _nullReceiversBuffer;
	}
}
