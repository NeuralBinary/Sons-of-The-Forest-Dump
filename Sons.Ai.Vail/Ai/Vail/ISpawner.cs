using System;
using System.Collections.Generic;
using Endnight.Utilities;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	public interface ISpawner
	{
		// Token: 0x0600057A RID: 1402
		[Token(Token = "0x600057A")]
		int GetCount();

		// Token: 0x0600057B RID: 1403
		[Token(Token = "0x600057B")]
		bool IsActive();

		// Token: 0x0600057C RID: 1404
		[Token(Token = "0x600057C")]
		int GetUniqueId();

		// Token: 0x0600057D RID: 1405
		[Token(Token = "0x600057D")]
		void GenerateUniqueId();

		// Token: 0x0600057E RID: 1406 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
		bool IsSaved()
		{
			return default(bool);
		}

		// Token: 0x0600057F RID: 1407
		[Token(Token = "0x600057F")]
		void OnLoad(VailWorldSimulation.VailSpawnerData savedData);

		// Token: 0x06000580 RID: 1408
		[Token(Token = "0x6000580")]
		VailWorldSimulation.VailSpawnerData GetSaveData();

		// Token: 0x06000581 RID: 1409
		[Token(Token = "0x6000581")]
		void Tick(float deltaTime);

		// Token: 0x06000582 RID: 1410
		[Token(Token = "0x6000582")]
		bool IsAlwaysRelevant();

		// Token: 0x06000583 RID: 1411
		[Token(Token = "0x6000583")]
		void UpdateRelevant(List<PlayerLocation.ViewerInfo> viewerList);

		// Token: 0x06000584 RID: 1412
		[Token(Token = "0x6000584")]
		void ForceDeactivate();

		// Token: 0x06000585 RID: 1413
		[Token(Token = "0x6000585")]
		string GetLabel();

		// Token: 0x06000586 RID: 1414
		[Token(Token = "0x6000586")]
		Vector3 GetLabelPosition();
	}
}
