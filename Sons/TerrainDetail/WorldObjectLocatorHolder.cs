using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x02000517 RID: 1303
	[Token(Token = "0x2000517")]
	[Tooltip("Holds the locator of the asset for saving / callbacks")]
	[AddComponentMenu("Sons/TerrainDetail/WorldObjectLocatorHolder")]
	public class WorldObjectLocatorHolder : MonoBehaviour
	{
		// Token: 0x0600224F RID: 8783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600224F")]
		[Address(RVA = "0x3339FF0", Offset = "0x33385F0", VA = "0x183339FF0")]
		public WorldLocatorId GetUniqueId()
		{
			return null;
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002250")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public WorldObjectLocator GetLocator()
		{
			return null;
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002251")]
		[Address(RVA = "0x333A010", Offset = "0x3338610", VA = "0x18333A010")]
		private void OnEnable()
		{
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002252")]
		[Address(RVA = "0x333A080", Offset = "0x3338680", VA = "0x18333A080")]
		private void OnDisable()
		{
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002253")]
		[Address(RVA = "0x333A140", Offset = "0x3338740", VA = "0x18333A140")]
		public void SetSource(WorldObjectLocator locatorSource)
		{
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002254")]
		[Address(RVA = "0x333A3A0", Offset = "0x33389A0", VA = "0x18333A3A0")]
		public void SetState(WorldObjectState newState, bool keepInstanceAlive = false)
		{
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002255")]
		[Address(RVA = "0x333A3E0", Offset = "0x33389E0", VA = "0x18333A3E0")]
		public void SetState(int newStateInt)
		{
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002256")]
		[Address(RVA = "0x333A410", Offset = "0x3338A10", VA = "0x18333A410")]
		public void SetState(WorldObjectState newState, GlobalTargets targets)
		{
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002257")]
		[Address(RVA = "0x333A4D0", Offset = "0x3338AD0", VA = "0x18333A4D0")]
		public void SetState(WorldObjectState newState, GlobalTargets targets, bool keepInstanceAlive)
		{
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002258")]
		[Address(RVA = "0x333A3E0", Offset = "0x33389E0", VA = "0x18333A3E0")]
		public void TestSetState(WorldObjectState newState)
		{
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x0000A200 File Offset: 0x00008400
		[Token(Token = "0x6002259")]
		[Address(RVA = "0x333A5A0", Offset = "0x3338BA0", VA = "0x18333A5A0")]
		public WorldObjectState GetCurrentState()
		{
			return WorldObjectState.Default;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x600225A")]
		[Address(RVA = "0x333A5C0", Offset = "0x3338BC0", VA = "0x18333A5C0")]
		public WorldObjectState GetPreviousState()
		{
			return WorldObjectState.Default;
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600225B")]
		[Address(RVA = "0x333A5E0", Offset = "0x3338BE0", VA = "0x18333A5E0")]
		public WorldObjectLocatorHolder SetOverrideTransformLod(Transform newTransform)
		{
			return null;
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225C")]
		[Address(RVA = "0x333A680", Offset = "0x3338C80", VA = "0x18333A680")]
		public void Release()
		{
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225D")]
		[Address(RVA = "0x333A6C0", Offset = "0x3338CC0", VA = "0x18333A6C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225E")]
		[Address(RVA = "0x333A730", Offset = "0x3338D30", VA = "0x18333A730")]
		public void ClearOverrideLod()
		{
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WorldObjectLocatorHolder()
		{
		}

		// Token: 0x04001F8A RID: 8074
		[Token(Token = "0x4001F8A")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private WorldObjectLocator _locatorSource;

		// Token: 0x04001F8B RID: 8075
		[Token(Token = "0x4001F8B")]
		[FieldOffset(Offset = "0x28")]
		public Action<Transform> OnDestroyed;

		// Token: 0x04001F8C RID: 8076
		[Token(Token = "0x4001F8C")]
		[FieldOffset(Offset = "0x30")]
		public Action<WorldObjectLocator> OnSourceChanged;

		// Token: 0x04001F8D RID: 8077
		[Token(Token = "0x4001F8D")]
		[FieldOffset(Offset = "0x38")]
		public Action<WorldObjectState, bool> OnStateChanged;
	}
}
