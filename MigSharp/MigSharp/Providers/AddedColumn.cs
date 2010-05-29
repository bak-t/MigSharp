﻿using System.Data;

using MigSharp.Core;

namespace MigSharp.Providers
{
    public class AddedColumn
    {
        private readonly string _name;
        private readonly DbType _type;
        private readonly bool _isNullable;
        private readonly object _defaultValue;
        private readonly AddColumnOptions _options;

        public string Name { get { return _name; } }
        public DbType Type { get { return _type; } }
        public bool IsNullable { get { return _isNullable; } }
        public object DefaultValue { get { return _defaultValue; } }
        public AddColumnOptions Options { get { return _options; } }

        public AddedColumn(string name, DbType type, bool isNullable, object defaultValue, AddColumnOptions options)
        {
            _name = name;
            _type = type;
            _isNullable = isNullable;
            _defaultValue = defaultValue;
            _options = options;
        }
    }
}