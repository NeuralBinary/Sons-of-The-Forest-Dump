using System;
using Il2CppDummyDll;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x02000837 RID: 2103
	[Token(Token = "0x2000837")]
	public class TreeRegrow : MonoBehaviour
	{
		// Token: 0x06003B84 RID: 15236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B84")]
		[Address(RVA = "0x358F7E0", Offset = "0x358DDE0", VA = "0x18358F7E0")]
		public void OnDestroy()
		{
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B85")]
		[Address(RVA = "0x358F7F0", Offset = "0x358DDF0", VA = "0x18358F7F0")]
		public void SetWorldObjectLocatorHolder(WorldObjectLocatorHolder newHolder)
		{
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B86")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetRootGameObject(GameObject targetGameObject)
		{
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B87")]
		[Address(RVA = "0x358F870", Offset = "0x358DE70", VA = "0x18358F870")]
		private void UnregisterCallbacks()
		{
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B88")]
		[Address(RVA = "0x358FB60", Offset = "0x358E160", VA = "0x18358FB60")]
		private void RegisterCallbacks()
		{
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B89")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnWorldObjectLocatorSourceChanged(WorldObjectLocator obj)
		{
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8A")]
		[Address(RVA = "0x358FE50", Offset = "0x358E450", VA = "0x18358FE50")]
		private void OnWorldObjectLocatorStateChanged(WorldObjectState state, bool fromSave)
		{
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8B")]
		[Address(RVA = "0x358FF70", Offset = "0x358E570", VA = "0x18358FF70")]
		public void Trigger()
		{
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8C")]
		[Address(RVA = "0x3590140", Offset = "0x358E740", VA = "0x183590140")]
		private void RefreshHolder()
		{
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TreeRegrow()
		{
		}

		// Token: 0x040032A0 RID: 12960
		[Token(Token = "0x40032A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rootGameObject;

		// Token: 0x040032A1 RID: 12961
		[Token(Token = "0x40032A1")]
		[FieldOffset(Offset = "0x28")]
		private WorldObjectLocatorHolder _worldObjectLocatorHolder;
	}
}
