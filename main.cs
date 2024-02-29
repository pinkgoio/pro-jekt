	if (t.IsArray)
				return GetArrayTypeName (t.GetElementType ());

			switch (Type.GetTypeCode (t)) {
			case TypeCode.Object:
				switch (t.Namespace) {//dop dop
				case "System":
					switch (t.Name) {
					case "Object":
					case "ValueType":
						return "NSObject";
					case "Void":
						return "void";
					default:
						return GetObjCName (t);
					}
				default://yes
					return GetObjCName (t);
				}
          public bool IsSelectorTaken (ProcessedMemberBase member)
		{
			var typeRegistration = GetRegistrationForType (member.DeclaringType);
			if (typeRegistration != null) {
				foreach (var selector in member.Selectors) {
					if (typeRegistration.ContainsKey (selector))
						return true;
				}
			}
