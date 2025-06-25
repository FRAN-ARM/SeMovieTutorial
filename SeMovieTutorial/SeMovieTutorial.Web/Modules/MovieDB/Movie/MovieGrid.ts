
namespace SeMovieTutorial.MovieDB {

    @Serenity.Decorators.registerClass()
    export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {
        protected getColumnsKey() { return 'MovieDB.Movie'; }
        protected getDialogType() { return MovieDialog; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getService() { return MovieService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            // let fld = MovieRow.Fields; No es valido porque se interpreta como un const. Hay que usarlo directamente.
            return [
                { name: "", title: "all" },
                { name: MovieRow.Fields.Description, title: "description" },
                { name: MovieRow.Fields.Storyline, title: "storyline" },
                { name: MovieRow.Fields.Year, title: "year" }
            ];
        }

        protected getQuickFilters() {
            let items = super.getQuickFilters();

            var genreListFilter = Q.first(items, x =>
                x.field == MovieRow.Fields.GenreList);

            genreListFilter.handler = h => {
                var request = (h.request as MovieListRequest);
                var values = (h.widget as Serenity.LookupEditor).values;
                request.Genres = values.map(x => parseInt(x, 10));
                h.handled = true;
            };

            return items;
        }

    }

    @Serenity.Decorators.registerFormatter()
    export class GenreListFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
            let idList = ctx.value as number[];

            if (!idList || !idList.length)
                return "";

            let byId = GenreRow.getLookup().itemById;

            return idList.map(x => {
                let g = byId[x];
                if (!g)
                    return x.toString();
                return Q.htmlEncode(g.Name);
            }).join(", ");

        }
    }
}