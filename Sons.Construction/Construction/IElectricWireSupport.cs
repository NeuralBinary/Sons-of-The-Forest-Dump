using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	public interface IElectricWireSupport : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000B1E RID: 2846
		[Token(Token = "0x6000B1E")]
		bool CanHostNewElectricWire();

		// Token: 0x06000B1F RID: 2847
		[Token(Token = "0x6000B1F")]
		void GetPlaceInfo(out Vector3 pos, out Vector3 axis);

		// Token: 0x06000B20 RID: 2848
		[Token(Token = "0x6000B20")]
		Directions GetElectricWireDir();

		// Token: 0x06000B21 RID: 2849
		[Token(Token = "0x6000B21")]
		Directions[] GetElectricWireSupportSiblingsDir();

		// Token: 0x06000B22 RID: 2850
		[Token(Token = "0x6000B22")]
		void GetElectricWireSupportAncestrySiblingsDir(IElectricWireSupport fromSupport, List<ElectricWireStructure> wireList);

		// Token: 0x06000B23 RID: 2851
		[Token(Token = "0x6000B23")]
		Directions[] GetPowerSourceSupportSiblingsDir();

		// Token: 0x06000B24 RID: 2852
		[Token(Token = "0x6000B24")]
		void SetElectricWire(ElectricWireStructure electricWire);

		// Token: 0x06000B25 RID: 2853
		[Token(Token = "0x6000B25")]
		bool TryGetElectricWire(out ElectricWireStructure electricWire);
	}
}
