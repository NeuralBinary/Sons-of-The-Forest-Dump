using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	public interface ISolarPanelSupport : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000B31 RID: 2865
		[Token(Token = "0x6000B31")]
		bool CanHostNewSolarPanel();

		// Token: 0x06000B32 RID: 2866
		[Token(Token = "0x6000B32")]
		Directions GetSolarPanelDir();

		// Token: 0x06000B33 RID: 2867
		[Token(Token = "0x6000B33")]
		Directions[] GetElectricWireSupportSiblingsDir();

		// Token: 0x06000B34 RID: 2868
		[Token(Token = "0x6000B34")]
		void SetSolarPanel(SolarPanelStructure solarPanel);

		// Token: 0x06000B35 RID: 2869
		[Token(Token = "0x6000B35")]
		bool TryGetSolarPanel(out SolarPanelStructure solarPanel);

		// Token: 0x06000B36 RID: 2870
		[Token(Token = "0x6000B36")]
		Vector3 GetSolarPanelSnapPos();
	}
}
