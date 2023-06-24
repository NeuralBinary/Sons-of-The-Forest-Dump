using System;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x02000757 RID: 1879
	[Token(Token = "0x2000757")]
	[AddComponentMenu("Sons/Gameplay/DeadTacticalSaveLoad")]
	public class DeadTacticalSaveLoad : MonoBehaviour
	{
		// Token: 0x060032D0 RID: 13008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D0")]
		[Address(RVA = "0x34AC1D0", Offset = "0x34AA7D0", VA = "0x1834AC1D0")]
		private void OnEnable()
		{
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D1")]
		[Address(RVA = "0x34AC350", Offset = "0x34AA950", VA = "0x1834AC350")]
		public void SaveAsSatisfied()
		{
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D2")]
		[Address(RVA = "0x34AC1D0", Offset = "0x34AA7D0", VA = "0x1834AC1D0")]
		private void SetupStateSync()
		{
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D3")]
		[Address(RVA = "0x34AC3C0", Offset = "0x34AA9C0", VA = "0x1834AC3C0")]
		private void AppliedState(NamedIntData saveValue)
		{
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D4")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DeadTacticalSaveLoad()
		{
		}

		// Token: 0x04002BE6 RID: 11238
		[Token(Token = "0x4002BE6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _saveDataId;

		// Token: 0x04002BE7 RID: 11239
		[Token(Token = "0x4002BE7")]
		[FieldOffset(Offset = "0x28")]
		private NamedIntData _namedIntData;

		// Token: 0x04002BE8 RID: 11240
		[Token(Token = "0x4002BE8")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("OnLoadedAndIsSatisfied")]
		[SerializeField]
		private UnityEvent _onLoadedAndIsSatisfied;
	}
}
