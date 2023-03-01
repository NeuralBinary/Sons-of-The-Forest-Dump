using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x0200065A RID: 1626
	[Token(Token = "0x200065A")]
	public class HangingTacticalSync : MonoBehaviour
	{
		// Token: 0x060029B6 RID: 10678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B6")]
		[Address(RVA = "0x2DCE730", Offset = "0x2DCD730", VA = "0x182DCE730")]
		public static List<string> ListForDropdown()
		{
			return null;
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B7")]
		[Address(RVA = "0x2DCE6F0", Offset = "0x2DCD6F0", VA = "0x182DCE6F0")]
		public void HangingTacticalCutDown()
		{
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B8")]
		[Address(RVA = "0x2DCE800", Offset = "0x2DCD800", VA = "0x182DCE800")]
		private void OnEnable()
		{
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B9")]
		[Address(RVA = "0x2DCE770", Offset = "0x2DCD770", VA = "0x182DCE770")]
		private void OnDisable()
		{
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BA")]
		[Address(RVA = "0x2DCE8E0", Offset = "0x2DCD8E0", VA = "0x182DCE8E0")]
		private void OnNamedIntDataChanged(NamedIntData data)
		{
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BB")]
		[Address(RVA = "0x2DCE910", Offset = "0x2DCD910", VA = "0x182DCE910")]
		private void SetStateValue(HangingTacticalState state)
		{
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BC")]
		[Address(RVA = "0x29B5280", Offset = "0x29B4280", VA = "0x1829B5280")]
		public void DoCutDown()
		{
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BD")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public HangingTacticalSync()
		{
		}

		// Token: 0x04002562 RID: 9570
		[Token(Token = "0x4002562")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _namedIntKey;

		// Token: 0x04002563 RID: 9571
		[Token(Token = "0x4002563")]
		[FieldOffset(Offset = "0x28")]
		private NamedIntData _namedIntData;

		// Token: 0x04002564 RID: 9572
		[Token(Token = "0x4002564")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onCutRopeEvent;
	}
}
