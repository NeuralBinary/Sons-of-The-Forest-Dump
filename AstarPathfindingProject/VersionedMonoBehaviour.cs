using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	public abstract class VersionedMonoBehaviour : MonoBehaviour, ISerializationCallbackReceiver, IVersionedMonoBehaviourInternal
	{
		// Token: 0x06000803 RID: 2051 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x6D29C0", Offset = "0x6D0FC0", VA = "0x1806D29C0", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x6D2A70", Offset = "0x6D1070", VA = "0x1806D2A70", Slot = "8")]
		protected virtual void Reset()
		{
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x6D2AA0", Offset = "0x6D10A0", VA = "0x1806D2AA0", Slot = "5")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00005B1C File Offset: 0x00003D1C
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "9")]
		protected virtual int OnUpgradeSerializedData(int version, bool unityThread)
		{
			return 0;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x6D2AD0", Offset = "0x6D10D0", VA = "0x1806D2AD0", Slot = "6")]
		private void UpgradeFromUnityThread()
		{
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected VersionedMonoBehaviour()
		{
		}

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private int version;
	}
}
