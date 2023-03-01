using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x0200050F RID: 1295
	[Token(Token = "0x200050F")]
	[AddComponentMenu("Sons/TerrainDetail/WorldObjectLocatorHolder")]
	[Tooltip("Holds the locator of the asset for saving / callbacks")]
	public class WorldObjectLocatorHolder : MonoBehaviour
	{
		// Token: 0x0600216E RID: 8558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216E")]
		[Address(RVA = "0x2D71F60", Offset = "0x2D70F60", VA = "0x182D71F60")]
		public WorldLocatorId GetUniqueId()
		{
			return null;
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216F")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
		public WorldObjectLocator GetLocator()
		{
			return null;
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002170")]
		[Address(RVA = "0x2D72040", Offset = "0x2D71040", VA = "0x182D72040")]
		private void OnEnable()
		{
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002171")]
		[Address(RVA = "0x2D71FC0", Offset = "0x2D70FC0", VA = "0x182D71FC0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002172")]
		[Address(RVA = "0x2D72110", Offset = "0x2D71110", VA = "0x182D72110")]
		public void SetSource(WorldObjectLocator locatorSource)
		{
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002173")]
		[Address(RVA = "0x2D724D0", Offset = "0x2D714D0", VA = "0x182D724D0")]
		public void SetState(WorldObjectState newState, bool keepInstanceAlive = false)
		{
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002174")]
		[Address(RVA = "0x2D72500", Offset = "0x2D71500", VA = "0x182D72500")]
		public void SetState(int newStateInt)
		{
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002175")]
		[Address(RVA = "0x2D72420", Offset = "0x2D71420", VA = "0x182D72420")]
		public void SetState(WorldObjectState newState, GlobalTargets targets)
		{
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002176")]
		[Address(RVA = "0x2D72360", Offset = "0x2D71360", VA = "0x182D72360")]
		public void SetState(WorldObjectState newState, GlobalTargets targets, bool keepInstanceAlive)
		{
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002177")]
		[Address(RVA = "0x2D72500", Offset = "0x2D71500", VA = "0x182D72500")]
		public void TestSetState(WorldObjectState newState)
		{
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00009BE8 File Offset: 0x00007DE8
		[Token(Token = "0x6002178")]
		[Address(RVA = "0x2D71F40", Offset = "0x2D70F40", VA = "0x182D71F40")]
		public WorldObjectState GetCurrentState()
		{
			return WorldObjectState.Default;
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002179")]
		[Address(RVA = "0x2D720F0", Offset = "0x2D710F0", VA = "0x182D720F0")]
		public WorldObjectLocatorHolder SetOverrideTransformLod(Transform newTransform)
		{
			return null;
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600217A")]
		[Address(RVA = "0x2D720B0", Offset = "0x2D710B0", VA = "0x182D720B0")]
		public void Release()
		{
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600217B")]
		[Address(RVA = "0x2D71F80", Offset = "0x2D70F80", VA = "0x182D71F80")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600217C")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public WorldObjectLocatorHolder()
		{
		}

		// Token: 0x04001EDA RID: 7898
		[Token(Token = "0x4001EDA")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private WorldObjectLocator _locatorSource;

		// Token: 0x04001EDB RID: 7899
		[Token(Token = "0x4001EDB")]
		[FieldOffset(Offset = "0x28")]
		public Action<Transform> OnDestroyed;

		// Token: 0x04001EDC RID: 7900
		[Token(Token = "0x4001EDC")]
		[FieldOffset(Offset = "0x30")]
		public Action<WorldObjectLocator> OnSourceChanged;

		// Token: 0x04001EDD RID: 7901
		[Token(Token = "0x4001EDD")]
		[FieldOffset(Offset = "0x38")]
		public Action<WorldObjectState> OnStateChanged;
	}
}
