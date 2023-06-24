using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007E5 RID: 2021
	[Token(Token = "0x20007E5")]
	[CreateAssetMenu(menuName = "Sons/Ai/RobbyOrderData", fileName = "RobbyOrderData", order = 0)]
	public class RobbyOrderData : ScriptableObject
	{
		// Token: 0x06003692 RID: 13970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003692")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public RobbyOrderData()
		{
		}

		// Token: 0x04002F29 RID: 12073
		[Token(Token = "0x4002F29")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal List<Robby.RobbyGetOrder> _getItemOrders;

		// Token: 0x04002F2A RID: 12074
		[Token(Token = "0x4002F2A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal List<Robby.RobbyBuildOrder> _buildItemOrders;

		// Token: 0x04002F2B RID: 12075
		[Token(Token = "0x4002F2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal List<Robby.RobbyClearOrder> _clearAreaOrders;

		// Token: 0x04002F2C RID: 12076
		[Token(Token = "0x4002F2C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal List<Robby.RobbyStayOrder> _stayOrders;
	}
}
