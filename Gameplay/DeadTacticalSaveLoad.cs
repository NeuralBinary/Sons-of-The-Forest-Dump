using System;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x0200063A RID: 1594
	[Token(Token = "0x200063A")]
	[AddComponentMenu("Sons/Gameplay/DeadTacticalSaveLoad")]
	public class DeadTacticalSaveLoad : MonoBehaviour
	{
		// Token: 0x060028F1 RID: 10481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F1")]
		[Address(RVA = "0x2DB5860", Offset = "0x2DB4860", VA = "0x182DB5860")]
		private void OnEnable()
		{
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F2")]
		[Address(RVA = "0x2DB5960", Offset = "0x2DB4960", VA = "0x182DB5960")]
		public void SaveAsSatisfied()
		{
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x2DB5860", Offset = "0x2DB4860", VA = "0x182DB5860")]
		private void SetupStateSync()
		{
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x2DB5820", Offset = "0x2DB4820", VA = "0x182DB5820")]
		private void AppliedState(NamedIntData saveValue)
		{
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public DeadTacticalSaveLoad()
		{
		}

		// Token: 0x040024A2 RID: 9378
		[Token(Token = "0x40024A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _saveDataId;

		// Token: 0x040024A3 RID: 9379
		[Token(Token = "0x40024A3")]
		[FieldOffset(Offset = "0x28")]
		private NamedIntData _namedIntData;

		// Token: 0x040024A4 RID: 9380
		[Token(Token = "0x40024A4")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("OnLoadedAndIsSatisfied")]
		[SerializeField]
		private UnityEvent _onLoadedAndIsSatisfied;
	}
}
