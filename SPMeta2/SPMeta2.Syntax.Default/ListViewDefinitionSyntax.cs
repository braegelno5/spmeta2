﻿using System;
using SPMeta2.Definitions;
using SPMeta2.Models;
using SPMeta2.Syntax.Default.Extensions;

namespace SPMeta2.Syntax.Default
{
    public static class ListViewDefinitionSyntax
    {
        #region methods

        [Obsolete("Use AddListView() methods instead")]
        public static ModelNode AddView(this ModelNode model, ListViewDefinition definition)
        {
            return AddView(model, definition, null);
        }

        [Obsolete("Use AddListView() methods instead")]
        public static ModelNode AddView(this ModelNode model, ListViewDefinition definition, Action<ModelNode> action)
        {
            return model.AddDefinitionNode(definition, action);
        }

        #endregion

        #region methods

        public static ModelNode AddListView(this ModelNode model, ListViewDefinition definition)
        {
            return AddListView(model, definition, null);
        }

        public static ModelNode AddListView(this ModelNode model, ListViewDefinition definition, Action<ModelNode> action)
        {
            return model.AddDefinitionNode(definition, action);
        }

        #endregion

        #region host override

        public static ModelNode AddHostView(this ModelNode model, ListViewDefinition definition)
        {
            return AddHostView(model, definition, null);
        }

        public static ModelNode AddHostView(this ModelNode model, ListViewDefinition definition, Action<ModelNode> action)
        {
            return model.AddDefinitionNodeWithOptions(definition, action, ModelNodeOptions.New().NoSelfProcessing());
        }

        #endregion
    }
}
