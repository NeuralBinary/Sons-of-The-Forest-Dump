using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006AF RID: 1711
	[Token(Token = "0x20006AF")]
	[CreateAssetMenu(menuName = "Sons/Ai/RobbyOrderData", fileName = "RobbyOrderData", order = 0)]
	public class RobbyOrderData : ScriptableObject
	{
		// Token: 0x06002BD8 RID: 11224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD8")]
		[Address(RVA = "0x539C30", Offset = "0x538C30", VA = "0x180539C30")]
		public RobbyOrderData()
		{
		}

		// Token: 0x04002753 RID: 10067
		[Token(Token = "0x4002753")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal List<Robby.RobbyGetOrder> _getItemOrders;

		// Token: 0x04002754 RID: 10068
		[Token(Token = "0x4002754")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal List<Robby.RobbyBuildOrder> _buildItemOrders;

		// Token: 0x04002755 RID: 10069
		[Token(Token = "0x4002755")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal List<Robby.RobbyClearOrder> _clearAreaOrders;

		// Token: 0x04002756 RID: 10070
		[Token(Token = "0x4002756")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal List<Robby.RobbyStayOrder> _stayOrders;
	}
}
