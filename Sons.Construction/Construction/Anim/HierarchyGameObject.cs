using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002B7 RID: 695
	[Token(Token = "0x20002B7")]
	[AddComponentMenu("Sons/Construction/HierarchyGameObject")]
	public class HierarchyGameObject : MonoBehaviour, IHierarchyGameObject, IMonoBehaviour
	{
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700045D")]
		public GameObjectIdentifier Identifier
		{
			[Token(Token = "0x60014F9")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x2DF99B0", Offset = "0x2DF7FB0", VA = "0x182DF99B0")]
		private void OnEnable()
		{
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x2DF9A20", Offset = "0x2DF8020", VA = "0x182DF9A20")]
		private void OnDisable()
		{
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0000C104 File Offset: 0x0000A304
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x2DF9A90", Offset = "0x2DF8090", VA = "0x182DF9A90")]
		private bool TryGetReceiver(out IHierarchyGameObjectReceiver receiver)
		{
			return default(bool);
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public HierarchyGameObject()
		{
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0000C11C File Offset: 0x0000A31C
		[Token(Token = "0x6001500")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObjectIdentifier _identifier;

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _receiverGO;

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x30")]
		private IHierarchyGameObjectReceiver _receiverCache;
	}
}
